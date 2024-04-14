using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace My_COM_Monitor_Port
{
    public partial class MainForm_ : Form
    {
        List<COMPort> COMPorts = new List<COMPort>();
        Timer Timer = new Timer();


        public MainForm_()
        {
            InitializeComponent();
            Timer.Interval = 50;
            Timer.Tick += Timer_Tick;
            Timer.Start();

            tabControl_ControlCountChange(null, null);
            LoadData();
        }

        #region Save and Load

        private void LoadData()
        {       
            this.Size = Properties.Settings.Default.lastSizeWindow;
            LoadPage();
        }

        private void LoadPage()
        {
            //MessageBox.Show(Properties.Settings.Default.pages);

            if (Properties.Settings.Default.pages != string.Empty)
            {
                if (MessageBox.Show("У вас есть сохранённые вкладки. Хотите их загрузить?", "Загрузить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            }
            else return;

            COMPortData[] cOMPorts;
            try
            {
                cOMPorts = JsonConvert.DeserializeObject<COMPortData[]>(Properties.Settings.Default.pages);
                if (cOMPorts == null) goto Error;
                foreach (COMPortData comport in cOMPorts) AddNewTabPage(comport);
            }
            catch (NullReferenceException)
            {
                goto Error;
            }

            return;
        Error:
            MessageBox.Show("Во время загрузки произошёл сбой. Данные сохранения сброшены.", "Ой!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Properties.Settings.Default.pages = string.Empty; Properties.Settings.Default.Save();
            return;
            
        }

        private void SavePage()
        {
            COMPortData[] cOMPorts = new COMPortData[COMPorts.Count];
            for (int i = 0; i < COMPorts.Count; i++)
                cOMPorts[i] = COMPorts[i].PackData();       
            Properties.Settings.Default.pages = JsonConvert.SerializeObject(cOMPorts);
            Properties.Settings.Default.Save();
        }
        #endregion

        private void PortUpdate()
        {
            try
            {
                toolStripComboBox_ports.Items.Clear();
                foreach (string i in SerialPort.GetPortNames())
                {
                    if (!toolStripComboBox_ports.Items.Contains(i))
                        toolStripComboBox_ports.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton_removePage_Click(object sender, EventArgs e)
        {
            COMPorts[tabControl.SelectedIndex].Dispose();
            COMPorts.RemoveAt(tabControl.SelectedIndex);
            tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
            tabControl_ControlCountChange(this, null);
        }

        private void ChangeTabPage(int ?index = null)
        {
            index = (index == null) ? tabControl.SelectedIndex : index;
            if ((int)index < 0) return;

            tabControl.SelectedIndex = (int)index;
            richTextBox_outCOM.Text = COMPorts[(int)index].MessageHistory;
            toolStripComboBox_ports.Text = COMPorts[(int)index].Port;
            toolStripComboBox_speed.Text = COMPorts[(int)index].Speed.ToString();
            checkBox_isAddTimeCommand.Checked = COMPorts[(int)index].AddedTimeInHistoryMessage;
            checkBox_streamRead.Checked = !COMPorts[(int)index].ReadLineOrReadExisting;
            checkBox_pause.Checked = COMPorts[(int)index].PauseDrawMessage;
            checkBox_add_newLine.Checked = COMPorts[(int)index].Added_NL_writeSerial;

            UI_Update();
        }

        private void AddNewTabPage(COMPortData cOMPortData = null)
        {
            PortUpdate();

            string serialName;
            if (cOMPortData == null)
                serialName = string.IsNullOrWhiteSpace(toolStripTextBoxSerialPortName.Text) ? $"Serial {tabControl.TabPages.Count}" : toolStripTextBoxSerialPortName.Text;
            else
            {
                serialName = cOMPortData.Name;
            }

            foreach (COMPort comp in COMPorts)
                if (comp.Name == serialName) // если уже существует
                {
                    if (cOMPortData != null)
                        MessageBox.Show(
                            $"Вкладка с именем \"{serialName}\" уже существует.", "Ой...",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                  

            tabControl.TabPages.Add(new TabPage(serialName));
            COMPorts.Add((cOMPortData == null) ? new COMPort(serialName) : new COMPort(cOMPortData));

            ChangeTabPage(tabControl.TabPages.Count - 1);
        }

        private void UI_Update()
        {
            if (tabControl.SelectedIndex == -1) return;
            COMPort obj;
            try
            {
                obj = COMPorts[tabControl.SelectedIndex];
            }
            catch { return; }

            toolStripButton_disconnect.Enabled = obj.IsConnected;
            toolStripButton_connect.Enabled = !obj.IsConnected;
            toolStripButton_openChart.Enabled = obj.IsConnected;
            toolStripButton_connect.Enabled = (toolStripComboBox_ports.Items.Contains(toolStripComboBox_ports.Text) && !obj.IsConnected && toolStripComboBox_speed.Items.Contains(toolStripComboBox_speed.Text));
            if (obj.IsConnected)
            {
                toolStripLabel_status.Text = "Подключено";
                toolStripLabel_status.ForeColor = Color.Green;

                button_SendCommand.Enabled = true;
                this.Text = $"My COM Monitor Port - ({obj.Name}: {obj.Port}, {obj.Speed}) - подключено";
            }
            if (!obj.IsConnected)
            {
                toolStripLabel_status.Text = "Отключено";
                toolStripLabel_status.ForeColor = Color.Red;

                button_SendCommand.Enabled = false;
                if (tabControl.SelectedIndex == -1) this.Text = "My COM Monitor Port";
                else this.Text = $"My COM Monitor Port - ({obj.Name}: {obj.Port}, {obj.Speed}) - отключено";
            }

            if (!checkBox_pause.Checked)
                richTextBox_outCOM.Text = obj.MessageHistory;
        }

        private void MainForm__FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tabControl.TabCount > 0)
            {
                if (MessageBox.Show("Сохранить вкладки и их данные?", "Сохранить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) SavePage();
                else
                {
                    Properties.Settings.Default.pages = string.Empty;
                    Properties.Settings.Default.Save();
                }
            }
            foreach(COMPort i in COMPorts) i.Dispose();  
        }

        private void MainForm__Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.lastSizeWindow = this.Size;
            Properties.Settings.Default.Save();
        }

        #region UI
        private void button_clear_Click(object sender, EventArgs e) => COMPorts[tabControl.SelectedIndex].ClearHistory();
        private void checkBox_streamRead_CheckedChanged(object sender, EventArgs e) => COMPorts[tabControl.SelectedIndex].ReadLineOrReadExisting = !((CheckBox)sender).Checked;
        private void checkBox_isAddTimeCommand_CheckedChanged(object sender, EventArgs e) => COMPorts[tabControl.SelectedIndex].AddedTimeInHistoryMessage = ((CheckBox)sender).Checked;
        private void tabControl_ControlCountChange(object sender, ControlEventArgs e)
        {
            toolStrip2.Enabled = (tabControl.TabCount != 0);
            panel1.Enabled = (tabControl.TabCount != 0);
            groupBox1.Enabled = (tabControl.TabCount != 0);
            groupBox2.Enabled = (tabControl.TabCount != 0);
        }
        private void toolStripButton_connect_Click(object sender, EventArgs e)
        {
            COMPorts[tabControl.SelectedIndex].Speed = Convert.ToInt32(toolStripComboBox_speed.Items[toolStripComboBox_speed.SelectedIndex]);
            COMPorts[tabControl.SelectedIndex].Port = toolStripComboBox_ports.Text;
            COMPorts[tabControl.SelectedIndex].Connect();
        }
        private void Timer_Tick(object sender, EventArgs e) => UI_Update();
        private void toolStripButton_disconnect_Click(object sender, EventArgs e) => COMPorts[tabControl.SelectedIndex].Disconnect();
        private void toolStripButton_addPage_Click(object sender, EventArgs e) => AddNewTabPage();
        private void toolStripButton_update_Click(object sender, EventArgs e)
        {
            PortUpdate();
            UI_Update();
        }
        private void button_SendCommand_Click(object sender, EventArgs e)
        {
            COMPorts[tabControl.SelectedIndex].SendCommsnd(
                (checkBox_add_newLine.Checked) ?
                textBox_SendCommand.Text + "\n"
                : textBox_SendCommand.Text
                );

            List<string> coms = new List<string>();
            foreach (string i in listBox_lastCommand.Items)
                coms.Add(i);

            coms.Reverse();
            coms.Add(textBox_SendCommand.Text);
            coms.Reverse();

            listBox_lastCommand.Items.Clear();
            listBox_lastCommand.Items.AddRange(coms.ToArray());

            textBox_SendCommand.Text = string.Empty;
        }
        private void listBox_lastCommand_SelectedIndexChanged(object sender, EventArgs e) => textBox_SendCommand.Text = listBox_lastCommand.SelectedItem.ToString();
        private void checkBox_pause_CheckedChanged(object sender, EventArgs e) => COMPorts[tabControl.SelectedIndex].PauseDrawMessage = ((CheckBox)sender).Checked;
        private void checkBox_add_newLine_CheckedChanged(object sender, EventArgs e) => COMPorts[tabControl.SelectedIndex].Added_NL_writeSerial = ((CheckBox)sender).Checked;
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) => ChangeTabPage();
        private void toolStripButton_About_Click(object sender, EventArgs e) => new AboutForm().ShowDialog();

        #endregion

        private void toolStripButton_openChart_Click(object sender, EventArgs e)
        {
            new ChartForm(COMPorts[tabControl.SelectedIndex]).Show();
        }
    }
}

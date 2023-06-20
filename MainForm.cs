using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_COM_Monitor_Port
{
    public partial class MainForm : Form
    {

        private string OUT_print = string.Empty;

        public MainForm()
        {
            InitializeComponent();
            PortUpdate();
            UI_Update();
            
        }

        private void PortUpdate()
        {
            try
            {
                toolStripComboBox_ports.Items.Clear();
                toolStripComboBox_ports.Items.AddRange(SerialPort.GetPortNames());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer_ConnectUpdate_Tick(object sender, EventArgs e)
        {
            UI_Update();
        }

        private void UI_Update()
        {
            toolStripButton_disconnect.Enabled = Port.IsOpen;
            toolStripButton_connect.Enabled = !Port.IsOpen;
            toolStripButton_connect.Enabled = (toolStripComboBox_ports.Items.Contains(toolStripComboBox_ports.Text) && !Port.IsOpen && toolStripComboBox_speed.Items.Contains(toolStripComboBox_speed.Text));
            if (Port.IsOpen)
            {
                toolStripLabel_status.Text = "Подключено";
                toolStripLabel_status.ForeColor = Color.Green;

                button_SendCommand.Enabled = true;
                this.Text = "My COM Monitor Port - (" + Port.PortName + ", " + Port.BaudRate.ToString() + ") - подключено";
            }
            if (!Port.IsOpen)
            {
                toolStripLabel_status.Text = "Отключено";
                toolStripLabel_status.ForeColor = Color.Red;

                button_SendCommand.Enabled = false;
                if(Port == null) this.Text = "My COM Monitor Port";
                else this.Text = "My COM Monitor Port - (" + Port.PortName + ", " + Port.BaudRate.ToString() + ") - отключено";
            }

            if(!checkBox_pause.Checked)
                richTextBox_outCOM.Text = OUT_print;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkBox_isAddTimeCommand.Checked = Properties.Settings.Default.isTimeMarks;
            this.Size = Properties.Settings.Default.lastSizeWindow;
        }

        private void toolStripButton_connect_Click(object sender, EventArgs e)
        {
            Port.PortName = toolStripComboBox_ports.Text;
            Port.BaudRate = Convert.ToInt32(toolStripComboBox_speed.Text);
            try
            {
                Port.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Порт занят!");
            }
            UI_Update();
        }

        private void toolStripButton_disconnect_Click(object sender, EventArgs e)
        {
            if(Port.IsOpen)
                Port.Close();
            UI_Update();
        }

        private void toolStripButton_update_Click(object sender, EventArgs e)
        {
            PortUpdate();
            UI_Update();
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (Port.IsOpen)
            {
                string str = string.Empty;
                try
                {
                    str = Port.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                if(checkBox_isAddTimeCommand.Checked)
                    OUT_print = System.DateTime.Now.ToString() + " -> " + str + OUT_print;
                else
                    OUT_print = str + OUT_print;
            }
        }

        private void button_SendCommand_Click(object sender, EventArgs e)
        {
            Send_Command();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_lastCommand.SelectedIndex == -1) return;
            textBox_SendCommand.Text = listBox_lastCommand.Items[listBox_lastCommand.SelectedIndex].ToString();
        }

        private void Send_Command()
        {
            if (!Port.IsOpen)
            {
                MessageBox.Show("Порт закрыт!");
                return;
            }
            if (checkBox1.Checked)
                Port.Write(textBox_SendCommand.Text + "\n");
            else
                Port.Write(textBox_SendCommand.Text);

            List<string> coms = new List<string>();
            foreach (string i in listBox_lastCommand.Items)
                coms.Add(i);

            coms.Reverse();
            coms.Add(textBox_SendCommand.Text);
            coms.Reverse();

            listBox_lastCommand.Items.Clear();
            listBox_lastCommand.Items.AddRange(coms.ToArray());

            textBox_SendCommand.Text = String.Empty;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            richTextBox_outCOM.Text = String.Empty;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text |.txt";
            if(saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
            File.WriteAllText(saveFileDialog.FileName, OUT_print);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.isTimeMarks = checkBox_isAddTimeCommand.Checked;
            Properties.Settings.Default.lastSizeWindow = this.Size;
            Properties.Settings.Default.Save();

            if(Port.IsOpen) Port.Close();
        }

        private void импортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "My COM Monitor Port History|.mcp";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            string data = File.ReadAllText(openFileDialog.FileName);
            bool isAdd = false;
            if (listBox_lastCommand.Items.Count != 0)
            {
                isAdd = MessageBox.Show("В списке уже есть данные. Хотите добавить из файла или заменить на данные из файла?", "?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes;
                if (MessageBox.Show("В списке уже есть данные. Хотите добавить из файла или заменить на данные из файла?", "?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Cancel) return;
            }
            List<string> lines = new List<string>();
            foreach(string i in data.Split("<<|-SPLITER-|>>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
                lines.Add(i);
            if (isAdd) listBox_lastCommand.Items.AddRange(lines.ToArray());
            else
            {
                listBox_lastCommand.Items.Clear();
                listBox_lastCommand.Items.AddRange(lines.ToArray());
            }
        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "My COM Monitor Port History|.mcp)";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
            string data = "";
            foreach(string i in listBox_lastCommand.Items)
                data += i + "<<|-SPLITER-|>>";
            File.WriteAllText(saveFileDialog.FileName, data.Remove(data.Length - 15, 15));
        }

        private void textBox_SendCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send_Command();
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
    }
}

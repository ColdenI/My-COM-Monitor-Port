using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace My_COM_Monitor_Port
{
    public partial class ChartForm : Form
    {
        private COMPort COMPort;
        private Timer Timer = new Timer();
        private Timer TimerUI = new Timer();

        private string lastData = "";
        private bool isPause = true;
        private int timm = 0;

        private bool _isSetupSeries = false;

        public ChartForm(COMPort cOMPort)
        {
            InitializeComponent();

            Timer.Interval = 20;
            trackBar_speedUpdate.Value = Timer.Interval;
            Timer.Tick += Timer_Tick;
            Timer.Start();

            TimerUI.Interval = 100;
            TimerUI.Tick += TimerUI_Tick;
            TimerUI.Start();

            COMPort = cOMPort;
            COMPort.SeriapPort_DataReceivedEvent += COMPort_SeriapPort_DataReceivedEvent;
            COMPort.SerialPortChangeConnectingEvent += COMPort_SerialPortChangeConnectingEvent;

            chart1.Series.Clear();
            //AddSeries("Series 1");

            comboBox_typeViewChart.Items.Add(SeriesChartType.Line);
            comboBox_typeViewChart.Items.Add(SeriesChartType.Spline);
            comboBox_typeViewChart.Items.Add(SeriesChartType.StepLine);
            comboBox_typeViewChart.Items.Add(SeriesChartType.FastLine);
            comboBox_typeViewChart.Items.Add(SeriesChartType.StackedArea100);
            comboBox_typeViewChart.SelectedIndex = 0;


        }

        private void COMPort_SerialPortChangeConnectingEvent(bool isConnecting) => ChartPause(isConnecting);

        private void COMPort_SeriapPort_DataReceivedEvent(string data)
        {
            lastData = data.Trim();
        }

        private struct SeriesDataCOM
        {
            public string name;
            public double value;
        };

        private SeriesDataCOM[] DecodeCOMSeries()
        {
            int count;
            string[] _nS, _vS;
            try
            {
                count = int.Parse(lastData.Split(':')[0]);
            }
            catch (Exception) { return null; }

            SeriesDataCOM[] data = new SeriesDataCOM[count];
            try
            {
                _nS = lastData.Split('{')[1].Split(':')[0].Split(',');
                _vS = lastData.Split(':')[2].Split('}')[0].Split(',');
            }
            catch (Exception) { return null; }
            for (int i = 0; i < count; i++)
            {
                try
                {
                    data[i].name = _nS[i].Trim();
                }
                catch (Exception) { return null; }
                try
                {
                    data[i].value = Convert.ToDouble(_vS[i].Trim().Replace('.', ','));
                }
                catch (Exception) { return null; }
            }

            return data;
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            // 3:{name,name2,name:12.34,543.3,3}
            SeriesDataCOM[] seriesDataCOMs = DecodeCOMSeries();

            if (!_isSetupSeries)
            {
                if (seriesDataCOMs != null)
                {
                    foreach (SeriesDataCOM data in DecodeCOMSeries())
                        AddSeries(data.name);
                    _isSetupSeries = true;
                }
            }

            if (seriesDataCOMs != null)
                for (int i = 0; i < seriesDataCOMs.Length; i++)
                    chart1.Series[i].Points.Add(seriesDataCOMs[i].value);

            timm++;

            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = timm;

            if (checkBox_autoScroll.Checked)
            {
                ChartScroll(timm);
            }

        }

        private void TimerUI_Tick(object sender, System.EventArgs e)
        {
            if (!isPause) button_pause.Text = "Продолжить";
            else button_pause.Text = "Пауза";

            this.Text = $"График - ({COMPort.Name}: {COMPort.Port}, {COMPort.Speed} - {COMPort.Status})";
            //button_settingsSeries.Enabled = (listBox_series.SelectedIndex != -1);

        }


        private void ChartScroll(int p)
        {
            hScrollBar1.Value = p;

            chart1.ChartAreas[0].AxisX.Maximum = p;
            chart1.ChartAreas[0].AxisX.Minimum = p - 100 * trackBar_areaX.Value / 100;

        }

        private void AddSeries(string name)
        {
            try
            {
                chart1.Series.Add(name);
            }
            catch (Exception ex) { return; }
            listBox_series.Items.Add(name);
            comboBox_typeViewChart_SelectedIndexChanged(null, null);
        }


        private void ChartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Timer.Stop();
            COMPort.SeriapPort_DataReceivedEvent -= COMPort_SeriapPort_DataReceivedEvent;
            COMPort.SerialPortChangeConnectingEvent -= COMPort_SerialPortChangeConnectingEvent;
            this.Dispose();
            GC.SuppressFinalize(this);
        }

        private void ChartPause(bool isPause)
        {
            Timer.Enabled = isPause;
            this.isPause = isPause;
        }

        private void ChartClear()
        {
            chart1.Series.Clear();
            listBox_series.Items.Clear();
            _isSetupSeries = false;
            timm = 0;
            Timer.Stop();
            if (isPause) Timer.Start();
        }

        #region UI
        private void button_pause_Click(object sender, EventArgs e) => ChartPause(!isPause);
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ChartScroll(hScrollBar1.Value);
        }

        private void trackBar_areaX_Scroll(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = timm - 100 * trackBar_areaX.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Timer.Interval = trackBar_speedUpdate.Value;
        }
        private void button_clear_Click(object sender, EventArgs e) => ChartClear();
        private void comboBox_typeViewChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Series i in chart1.Series)
            {
                i.ChartType = (SeriesChartType)comboBox_typeViewChart.SelectedItem;
            }
        }
        private void button_addSeries_Click(object sender, EventArgs e) => MessageBox.Show("Для построения графика по COM port должно быть отправлена строка в виде:\r\n3:{name ,name 2, name 3:12.34,543.3,3}\r\n[количество линий]:{[имя 1],[имя 2],[имя 3]:[значение],[значение],[значение]}\r\nИмена не должны повторяться!\r\n", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        #endregion


    }
}

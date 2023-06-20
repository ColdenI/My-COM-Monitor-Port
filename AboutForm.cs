using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_COM_Monitor_Port
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://akylinandrej.wixsite.com/colden-i/my-com-monitor-port");
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Process.Start("https://akylinandrej.wixsite.com/colden-i");
        }
    }
}

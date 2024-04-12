namespace My_COM_Monitor_Port
{
    partial class MainForm_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_addPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxSerialPortName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_removePage = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_ports = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_speed = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_connect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_disconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_update = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_status = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_SendCommand = new System.Windows.Forms.TextBox();
            this.button_SendCommand = new System.Windows.Forms.Button();
            this.checkBox_add_newLine = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_outCOM = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox_pause = new System.Windows.Forms.CheckBox();
            this.checkBox_isAddTimeCommand = new System.Windows.Forms.CheckBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_lastCommand = new System.Windows.Forms.ListBox();
            this.checkBox_streamRead = new System.Windows.Forms.CheckBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_addPage,
            this.toolStripTextBoxSerialPortName,
            this.toolStripSeparator1,
            this.toolStripButton_removePage,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(986, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip";
            // 
            // toolStripButton_addPage
            // 
            this.toolStripButton_addPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_addPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_addPage.Image")));
            this.toolStripButton_addPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_addPage.Name = "toolStripButton_addPage";
            this.toolStripButton_addPage.Size = new System.Drawing.Size(80, 24);
            this.toolStripButton_addPage.Text = "Добавить";
            this.toolStripButton_addPage.Click += new System.EventHandler(this.toolStripButton_addPage_Click);
            // 
            // toolStripTextBoxSerialPortName
            // 
            this.toolStripTextBoxSerialPortName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxSerialPortName.Name = "toolStripTextBoxSerialPortName";
            this.toolStripTextBoxSerialPortName.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_removePage
            // 
            this.toolStripButton_removePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_removePage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_removePage.Image")));
            this.toolStripButton_removePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_removePage.Name = "toolStripButton_removePage";
            this.toolStripButton_removePage.Size = new System.Drawing.Size(69, 24);
            this.toolStripButton_removePage.Text = "Удалить";
            this.toolStripButton_removePage.Click += new System.EventHandler(this.toolStripButton_removePage_Click);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(986, 24);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabControl_ControlCountChange);
            this.tabControl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tabControl_ControlCountChange);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox_ports,
            this.toolStripLabel2,
            this.toolStripComboBox_speed,
            this.toolStripSeparator2,
            this.toolStripButton_connect,
            this.toolStripButton_disconnect,
            this.toolStripButton_update,
            this.toolStripLabel_status,
            this.toolStripLabel3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 51);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(986, 28);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 25);
            this.toolStripLabel1.Text = "Порт:";
            // 
            // toolStripComboBox_ports
            // 
            this.toolStripComboBox_ports.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripComboBox_ports.Name = "toolStripComboBox_ports";
            this.toolStripComboBox_ports.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(76, 25);
            this.toolStripLabel2.Text = "Скорость:";
            // 
            // toolStripComboBox_speed
            // 
            this.toolStripComboBox_speed.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripComboBox_speed.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000",
            "500000",
            "1000000",
            "2000000"});
            this.toolStripComboBox_speed.Name = "toolStripComboBox_speed";
            this.toolStripComboBox_speed.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton_connect
            // 
            this.toolStripButton_connect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_connect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_connect.Image")));
            this.toolStripButton_connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_connect.Name = "toolStripButton_connect";
            this.toolStripButton_connect.Size = new System.Drawing.Size(99, 25);
            this.toolStripButton_connect.Text = "Подключить";
            this.toolStripButton_connect.Click += new System.EventHandler(this.toolStripButton_connect_Click);
            // 
            // toolStripButton_disconnect
            // 
            this.toolStripButton_disconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_disconnect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_disconnect.Image")));
            this.toolStripButton_disconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_disconnect.Name = "toolStripButton_disconnect";
            this.toolStripButton_disconnect.Size = new System.Drawing.Size(88, 25);
            this.toolStripButton_disconnect.Text = "Отключить";
            this.toolStripButton_disconnect.Click += new System.EventHandler(this.toolStripButton_disconnect_Click);
            // 
            // toolStripButton_update
            // 
            this.toolStripButton_update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_update.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_update.Image")));
            this.toolStripButton_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_update.Name = "toolStripButton_update";
            this.toolStripButton_update.Size = new System.Drawing.Size(82, 25);
            this.toolStripButton_update.Text = "Обновить";
            this.toolStripButton_update.Click += new System.EventHandler(this.toolStripButton_update_Click);
            // 
            // toolStripLabel_status
            // 
            this.toolStripLabel_status.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_status.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel_status.Name = "toolStripLabel_status";
            this.toolStripLabel_status.Size = new System.Drawing.Size(62, 25);
            this.toolStripLabel_status.Text = "\\Status\\";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(56, 25);
            this.toolStripLabel3.Text = "Статус:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.textBox_SendCommand);
            this.panel1.Controls.Add(this.button_SendCommand);
            this.panel1.Controls.Add(this.checkBox_add_newLine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 58);
            this.panel1.TabIndex = 17;
            // 
            // textBox_SendCommand
            // 
            this.textBox_SendCommand.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_SendCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SendCommand.Location = new System.Drawing.Point(0, 0);
            this.textBox_SendCommand.Name = "textBox_SendCommand";
            this.textBox_SendCommand.Size = new System.Drawing.Size(986, 27);
            this.textBox_SendCommand.TabIndex = 1;
            // 
            // button_SendCommand
            // 
            this.button_SendCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SendCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SendCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SendCommand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_SendCommand.Location = new System.Drawing.Point(889, 29);
            this.button_SendCommand.Name = "button_SendCommand";
            this.button_SendCommand.Size = new System.Drawing.Size(93, 25);
            this.button_SendCommand.TabIndex = 2;
            this.button_SendCommand.Text = "Отправить";
            this.button_SendCommand.UseVisualStyleBackColor = true;
            this.button_SendCommand.Click += new System.EventHandler(this.button_SendCommand_Click);
            // 
            // checkBox_add_newLine
            // 
            this.checkBox_add_newLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_add_newLine.AutoSize = true;
            this.checkBox_add_newLine.Location = new System.Drawing.Point(841, 33);
            this.checkBox_add_newLine.Name = "checkBox_add_newLine";
            this.checkBox_add_newLine.Size = new System.Drawing.Size(46, 20);
            this.checkBox_add_newLine.TabIndex = 3;
            this.checkBox_add_newLine.Text = "NL";
            this.checkBox_add_newLine.UseVisualStyleBackColor = true;
            this.checkBox_add_newLine.CheckedChanged += new System.EventHandler(this.checkBox_add_newLine_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 137);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(986, 313);
            this.splitContainer1.SplitterDistance = 639;
            this.splitContainer1.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox_outCOM);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(639, 313);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "История";
            // 
            // richTextBox_outCOM
            // 
            this.richTextBox_outCOM.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_outCOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_outCOM.Location = new System.Drawing.Point(3, 18);
            this.richTextBox_outCOM.Name = "richTextBox_outCOM";
            this.richTextBox_outCOM.ReadOnly = true;
            this.richTextBox_outCOM.ShortcutsEnabled = false;
            this.richTextBox_outCOM.Size = new System.Drawing.Size(633, 260);
            this.richTextBox_outCOM.TabIndex = 8;
            this.richTextBox_outCOM.TabStop = false;
            this.richTextBox_outCOM.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.checkBox_streamRead);
            this.panel2.Controls.Add(this.checkBox_pause);
            this.panel2.Controls.Add(this.checkBox_isAddTimeCommand);
            this.panel2.Controls.Add(this.button_clear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 32);
            this.panel2.TabIndex = 19;
            // 
            // checkBox_pause
            // 
            this.checkBox_pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_pause.AutoSize = true;
            this.checkBox_pause.Location = new System.Drawing.Point(160, 7);
            this.checkBox_pause.Name = "checkBox_pause";
            this.checkBox_pause.Size = new System.Drawing.Size(153, 20);
            this.checkBox_pause.TabIndex = 15;
            this.checkBox_pause.Text = "Пауза заполнения";
            this.checkBox_pause.UseVisualStyleBackColor = true;
            this.checkBox_pause.CheckedChanged += new System.EventHandler(this.checkBox_pause_CheckedChanged);
            // 
            // checkBox_isAddTimeCommand
            // 
            this.checkBox_isAddTimeCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_isAddTimeCommand.AutoSize = true;
            this.checkBox_isAddTimeCommand.Location = new System.Drawing.Point(325, 7);
            this.checkBox_isAddTimeCommand.Name = "checkBox_isAddTimeCommand";
            this.checkBox_isAddTimeCommand.Size = new System.Drawing.Size(200, 20);
            this.checkBox_isAddTimeCommand.TabIndex = 14;
            this.checkBox_isAddTimeCommand.Text = "Ставить отметки времени";
            this.checkBox_isAddTimeCommand.UseVisualStyleBackColor = true;
            this.checkBox_isAddTimeCommand.CheckedChanged += new System.EventHandler(this.checkBox_isAddTimeCommand_CheckedChanged);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_clear.Location = new System.Drawing.Point(531, 3);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(99, 27);
            this.button_clear.TabIndex = 11;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_lastCommand);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 313);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "История команд";
            // 
            // listBox_lastCommand
            // 
            this.listBox_lastCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox_lastCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_lastCommand.FormattingEnabled = true;
            this.listBox_lastCommand.ItemHeight = 16;
            this.listBox_lastCommand.Location = new System.Drawing.Point(3, 18);
            this.listBox_lastCommand.Name = "listBox_lastCommand";
            this.listBox_lastCommand.Size = new System.Drawing.Size(337, 292);
            this.listBox_lastCommand.TabIndex = 13;
            this.listBox_lastCommand.SelectedIndexChanged += new System.EventHandler(this.listBox_lastCommand_SelectedIndexChanged);
            // 
            // checkBox_streamRead
            // 
            this.checkBox_streamRead.AutoSize = true;
            this.checkBox_streamRead.Location = new System.Drawing.Point(3, 7);
            this.checkBox_streamRead.Name = "checkBox_streamRead";
            this.checkBox_streamRead.Size = new System.Drawing.Size(151, 20);
            this.checkBox_streamRead.TabIndex = 16;
            this.checkBox_streamRead.Text = "Потоковое чтение";
            this.checkBox_streamRead.UseVisualStyleBackColor = true;
            this.checkBox_streamRead.CheckedChanged += new System.EventHandler(this.checkBox_streamRead_CheckedChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(110, 24);
            this.toolStripButton1.Text = "О Программе";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton_About_Click);
            // 
            // MainForm_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm_";
            this.Text = "My COM Monitor Port";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm__FormClosing);
            this.Resize += new System.EventHandler(this.MainForm__Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_addPage;
        private System.Windows.Forms.ToolStripButton toolStripButton_removePage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_ports;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_speed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_connect;
        private System.Windows.Forms.ToolStripButton toolStripButton_disconnect;
        private System.Windows.Forms.ToolStripButton toolStripButton_update;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_status;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_SendCommand;
        private System.Windows.Forms.Button button_SendCommand;
        private System.Windows.Forms.CheckBox checkBox_add_newLine;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox_outCOM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox_pause;
        private System.Windows.Forms.CheckBox checkBox_isAddTimeCommand;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_lastCommand;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSerialPortName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox checkBox_streamRead;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
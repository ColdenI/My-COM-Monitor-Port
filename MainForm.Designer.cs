﻿namespace My_COM_Monitor_Port
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer_ConnectUpdate = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_ports = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_speed = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_connect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_disconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_update = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_status = new System.Windows.Forms.ToolStripLabel();
            this.textBox_SendCommand = new System.Windows.Forms.TextBox();
            this.richTextBox_outCOM = new System.Windows.Forms.RichTextBox();
            this.button_SendCommand = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.listBox_lastCommand = new System.Windows.Forms.ListBox();
            this.checkBox_isAddTimeCommand = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.историяКомандToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_ConnectUpdate
            // 
            this.timer_ConnectUpdate.Enabled = true;
            this.timer_ConnectUpdate.Interval = 50;
            this.timer_ConnectUpdate.Tick += new System.EventHandler(this.timer_ConnectUpdate_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(822, 28);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 28);
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
            this.toolStripLabel2.Size = new System.Drawing.Size(76, 28);
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
            "9800",
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
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
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
            this.toolStripButton_disconnect.Size = new System.Drawing.Size(88, 28);
            this.toolStripButton_disconnect.Text = "Отключить";
            this.toolStripButton_disconnect.Click += new System.EventHandler(this.toolStripButton_disconnect_Click);
            // 
            // toolStripButton_update
            // 
            this.toolStripButton_update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_update.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_update.Image")));
            this.toolStripButton_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_update.Name = "toolStripButton_update";
            this.toolStripButton_update.Size = new System.Drawing.Size(82, 28);
            this.toolStripButton_update.Text = "Обновить";
            this.toolStripButton_update.Click += new System.EventHandler(this.toolStripButton_update_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(56, 25);
            this.toolStripLabel3.Text = "Статус:";
            // 
            // toolStripLabel_status
            // 
            this.toolStripLabel_status.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_status.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel_status.Name = "toolStripLabel_status";
            this.toolStripLabel_status.Size = new System.Drawing.Size(62, 25);
            this.toolStripLabel_status.Text = "\\Status\\";
            // 
            // textBox_SendCommand
            // 
            this.textBox_SendCommand.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_SendCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SendCommand.Location = new System.Drawing.Point(0, 0);
            this.textBox_SendCommand.Name = "textBox_SendCommand";
            this.textBox_SendCommand.Size = new System.Drawing.Size(822, 27);
            this.textBox_SendCommand.TabIndex = 1;
            this.textBox_SendCommand.TextChanged += new System.EventHandler(this.textBox_SendCommand_TextChanged_1);
            // 
            // richTextBox_outCOM
            // 
            this.richTextBox_outCOM.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_outCOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_outCOM.Location = new System.Drawing.Point(3, 18);
            this.richTextBox_outCOM.Name = "richTextBox_outCOM";
            this.richTextBox_outCOM.ReadOnly = true;
            this.richTextBox_outCOM.Size = new System.Drawing.Size(528, 303);
            this.richTextBox_outCOM.TabIndex = 8;
            this.richTextBox_outCOM.Text = "";
            // 
            // button_SendCommand
            // 
            this.button_SendCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SendCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SendCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SendCommand.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_SendCommand.Location = new System.Drawing.Point(725, 29);
            this.button_SendCommand.Name = "button_SendCommand";
            this.button_SendCommand.Size = new System.Drawing.Size(93, 25);
            this.button_SendCommand.TabIndex = 2;
            this.button_SendCommand.Text = "Отправить";
            this.button_SendCommand.UseVisualStyleBackColor = true;
            this.button_SendCommand.Click += new System.EventHandler(this.button_SendCommand_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_clear.Location = new System.Drawing.Point(426, 3);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(99, 27);
            this.button_clear.TabIndex = 11;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(677, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "NL";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Port
            // 
            this.Port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Port_DataReceived);
            // 
            // listBox_lastCommand
            // 
            this.listBox_lastCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox_lastCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_lastCommand.FormattingEnabled = true;
            this.listBox_lastCommand.ItemHeight = 16;
            this.listBox_lastCommand.Location = new System.Drawing.Point(3, 18);
            this.listBox_lastCommand.Name = "listBox_lastCommand";
            this.listBox_lastCommand.Size = new System.Drawing.Size(278, 335);
            this.listBox_lastCommand.TabIndex = 13;
            this.listBox_lastCommand.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkBox_isAddTimeCommand
            // 
            this.checkBox_isAddTimeCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_isAddTimeCommand.AutoSize = true;
            this.checkBox_isAddTimeCommand.Location = new System.Drawing.Point(220, 7);
            this.checkBox_isAddTimeCommand.Name = "checkBox_isAddTimeCommand";
            this.checkBox_isAddTimeCommand.Size = new System.Drawing.Size(200, 20);
            this.checkBox_isAddTimeCommand.TabIndex = 14;
            this.checkBox_isAddTimeCommand.Text = "Ставить отметки времени";
            this.checkBox_isAddTimeCommand.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.историяКомандToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.textBox_SendCommand);
            this.panel1.Controls.Add(this.button_SendCommand);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 58);
            this.panel1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_lastCommand);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 356);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "История команд";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox_outCOM);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 356);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "История";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.checkBox_isAddTimeCommand);
            this.panel2.Controls.Add(this.button_clear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 32);
            this.panel2.TabIndex = 19;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 114);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(822, 356);
            this.splitContainer1.SplitterDistance = 534;
            this.splitContainer1.TabIndex = 19;
            // 
            // историяКомандToolStripMenuItem
            // 
            this.историяКомандToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортToolStripMenuItem,
            this.экспортToolStripMenuItem});
            this.историяКомандToolStripMenuItem.Name = "историяКомандToolStripMenuItem";
            this.историяКомандToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.историяКомандToolStripMenuItem.Text = "История команд";
            // 
            // импортToolStripMenuItem
            // 
            this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            this.импортToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.импортToolStripMenuItem.Text = "Импорт";
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.оПрограммеToolStripMenuItem.Text = "О Программе";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 470);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(840, 47);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_ConnectUpdate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_ports;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_speed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_connect;
        private System.Windows.Forms.ToolStripButton toolStripButton_disconnect;
        private System.Windows.Forms.ToolStripButton toolStripButton_update;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_status;
        private System.Windows.Forms.TextBox textBox_SendCommand;
        private System.Windows.Forms.RichTextBox richTextBox_outCOM;
        private System.Windows.Forms.Button button_SendCommand;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.IO.Ports.SerialPort Port;
        private System.Windows.Forms.ListBox listBox_lastCommand;
        private System.Windows.Forms.CheckBox checkBox_isAddTimeCommand;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem историяКомандToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}


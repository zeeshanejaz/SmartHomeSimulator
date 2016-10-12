namespace SmartHomeSimulator
{
    partial class ViewForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabFloors = new System.Windows.Forms.TabControl();
            this.tabControlBottom = new System.Windows.Forms.TabControl();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.tabPageTestDirect = new System.Windows.Forms.TabPage();
            this.ctlTestDirectPacket1 = new SmartHomeSimulator.ctlTestDirectPacket();
            this.tabPageTestSocket = new System.Windows.Forms.TabPage();
            this.ctlTestSocketPacket1 = new SmartHomeSimulator.Test.ctlTestSocketPacket();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctlTestSocketPacket2 = new SmartHomeSimulator.Test.ctlTestSocketPacket();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            this.tabControlBottom.SuspendLayout();
            this.tabPageLogs.SuspendLayout();
            this.tabPageTestDirect.SuspendLayout();
            this.tabPageTestSocket.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusConnection});
            this.statusStrip.Location = new System.Drawing.Point(3, 566);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(848, 25);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusConnection
            // 
            this.statusConnection.AutoSize = false;
            this.statusConnection.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusConnection.Image = global::SmartHomeSimulator.Properties.Resources.red;
            this.statusConnection.Name = "statusConnection";
            this.statusConnection.Size = new System.Drawing.Size(99, 20);
            this.statusConnection.Text = "Disconnected";
            // 
            // tabFloors
            // 
            this.tabFloors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFloors.Location = new System.Drawing.Point(3, 1);
            this.tabFloors.Margin = new System.Windows.Forms.Padding(5);
            this.tabFloors.Name = "tabFloors";
            this.tabFloors.Padding = new System.Drawing.Point(5, 5);
            this.tabFloors.SelectedIndex = 0;
            this.tabFloors.Size = new System.Drawing.Size(848, 435);
            this.tabFloors.TabIndex = 1;
            // 
            // tabControlBottom
            // 
            this.tabControlBottom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlBottom.Controls.Add(this.tabPageLogs);
            this.tabControlBottom.Controls.Add(this.tabPageTestDirect);
            this.tabControlBottom.Controls.Add(this.tabPageTestSocket);
            this.tabControlBottom.Controls.Add(this.tabPage1);
            this.tabControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlBottom.Location = new System.Drawing.Point(3, 439);
            this.tabControlBottom.Name = "tabControlBottom";
            this.tabControlBottom.SelectedIndex = 0;
            this.tabControlBottom.Size = new System.Drawing.Size(848, 127);
            this.tabControlBottom.TabIndex = 2;
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.Controls.Add(this.listBoxLogs);
            this.tabPageLogs.Location = new System.Drawing.Point(4, 4);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogs.Size = new System.Drawing.Size(840, 101);
            this.tabPageLogs.TabIndex = 0;
            this.tabPageLogs.Text = "Logs";
            this.tabPageLogs.UseVisualStyleBackColor = true;
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.Location = new System.Drawing.Point(3, 3);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(834, 95);
            this.listBoxLogs.TabIndex = 1;
            // 
            // tabPageTestDirect
            // 
            this.tabPageTestDirect.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTestDirect.Controls.Add(this.ctlTestDirectPacket1);
            this.tabPageTestDirect.Location = new System.Drawing.Point(4, 4);
            this.tabPageTestDirect.Name = "tabPageTestDirect";
            this.tabPageTestDirect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTestDirect.Size = new System.Drawing.Size(840, 101);
            this.tabPageTestDirect.TabIndex = 1;
            this.tabPageTestDirect.Text = "Test Direct";
            // 
            // ctlTestDirectPacket1
            // 
            this.ctlTestDirectPacket1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTestDirectPacket1.Location = new System.Drawing.Point(3, 3);
            this.ctlTestDirectPacket1.Name = "ctlTestDirectPacket1";
            this.ctlTestDirectPacket1.Size = new System.Drawing.Size(834, 95);
            this.ctlTestDirectPacket1.TabIndex = 0;
            // 
            // tabPageTestSocket
            // 
            this.tabPageTestSocket.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTestSocket.Controls.Add(this.ctlTestSocketPacket1);
            this.tabPageTestSocket.Location = new System.Drawing.Point(4, 4);
            this.tabPageTestSocket.Name = "tabPageTestSocket";
            this.tabPageTestSocket.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTestSocket.Size = new System.Drawing.Size(840, 101);
            this.tabPageTestSocket.TabIndex = 2;
            this.tabPageTestSocket.Text = "Test Socket 1";
            // 
            // ctlTestSocketPacket1
            // 
            this.ctlTestSocketPacket1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTestSocketPacket1.Location = new System.Drawing.Point(3, 3);
            this.ctlTestSocketPacket1.Name = "ctlTestSocketPacket1";
            this.ctlTestSocketPacket1.Size = new System.Drawing.Size(834, 95);
            this.ctlTestSocketPacket1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctlTestSocketPacket2);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(840, 101);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Test Socket 2";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ctlTestSocketPacket2
            // 
            this.ctlTestSocketPacket2.BackColor = System.Drawing.SystemColors.Control;
            this.ctlTestSocketPacket2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTestSocketPacket2.Location = new System.Drawing.Point(3, 3);
            this.ctlTestSocketPacket2.Name = "ctlTestSocketPacket2";
            this.ctlTestSocketPacket2.Size = new System.Drawing.Size(834, 95);
            this.ctlTestSocketPacket2.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(3, 436);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(848, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(852, 596);
            this.Controls.Add(this.tabFloors);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControlBottom);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewForm";
            this.Padding = new System.Windows.Forms.Padding(3, 1, 1, 5);
            this.Text = "SmartHome Simulator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControlBottom.ResumeLayout(false);
            this.tabPageLogs.ResumeLayout(false);
            this.tabPageTestDirect.ResumeLayout(false);
            this.tabPageTestSocket.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusConnection;
        private System.Windows.Forms.TabControl tabFloors;
        private System.Windows.Forms.TabControl tabControlBottom;
        private System.Windows.Forms.TabPage tabPageLogs;
        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage tabPageTestDirect;
        private ctlTestDirectPacket ctlTestDirectPacket1;
        private System.Windows.Forms.TabPage tabPageTestSocket;
        private Test.ctlTestSocketPacket ctlTestSocketPacket1;
        private System.Windows.Forms.TabPage tabPage1;
        private Test.ctlTestSocketPacket ctlTestSocketPacket2;
        private System.Windows.Forms.Timer timer;
    }
}


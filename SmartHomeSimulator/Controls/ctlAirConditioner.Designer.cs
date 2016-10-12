namespace SmartHomeSimulator.Controls
{
    partial class ctlAirConditioner
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonUp = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFunction = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelDesired = new System.Windows.Forms.Label();
            this.buttonDown = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.checkBoxOnlineStatus = new System.Windows.Forms.CheckBox();
            this.checkBoxPoweredOn = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUp.Location = new System.Drawing.Point(4, 30);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(73, 68);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList.ImageSize = new System.Drawing.Size(48, 48);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 127);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelFunction);
            this.panel1.Controls.Add(this.labelCurrent);
            this.panel1.Controls.Add(this.labelDesired);
            this.panel1.Controls.Add(this.buttonDown);
            this.panel1.Controls.Add(this.buttonUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(17, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 119);
            this.panel1.TabIndex = 4;
            // 
            // labelFunction
            // 
            this.labelFunction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFunction.AutoSize = true;
            this.labelFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFunction.Location = new System.Drawing.Point(111, 90);
            this.labelFunction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(65, 20);
            this.labelFunction.TabIndex = 6;
            this.labelFunction.Text = "Cooling";
            this.labelFunction.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelCurrent
            // 
            this.labelCurrent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrent.Location = new System.Drawing.Point(111, 7);
            this.labelCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(51, 20);
            this.labelCurrent.TabIndex = 5;
            this.labelCurrent.Text = "30 °C";
            // 
            // labelDesired
            // 
            this.labelDesired.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDesired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDesired.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesired.Location = new System.Drawing.Point(107, 4);
            this.labelDesired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesired.Name = "labelDesired";
            this.labelDesired.Size = new System.Drawing.Size(113, 110);
            this.labelDesired.TabIndex = 4;
            this.labelDesired.Text = "22";
            this.labelDesired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDown.Location = new System.Drawing.Point(248, 30);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(73, 68);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(331, 132);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 10;
            this.labelID.Text = "ID";
            // 
            // checkBoxOnlineStatus
            // 
            this.checkBoxOnlineStatus.AutoSize = true;
            this.checkBoxOnlineStatus.Checked = true;
            this.checkBoxOnlineStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOnlineStatus.Location = new System.Drawing.Point(91, 130);
            this.checkBoxOnlineStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxOnlineStatus.Name = "checkBoxOnlineStatus";
            this.checkBoxOnlineStatus.Size = new System.Drawing.Size(71, 21);
            this.checkBoxOnlineStatus.TabIndex = 9;
            this.checkBoxOnlineStatus.Text = "Online";
            this.checkBoxOnlineStatus.UseVisualStyleBackColor = true;
            this.checkBoxOnlineStatus.CheckedChanged += new System.EventHandler(this.checkBoxOnlineStatus_CheckedChanged);
            // 
            // checkBoxPoweredOn
            // 
            this.checkBoxPoweredOn.AutoSize = true;
            this.checkBoxPoweredOn.Location = new System.Drawing.Point(4, 130);
            this.checkBoxPoweredOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPoweredOn.Name = "checkBoxPoweredOn";
            this.checkBoxPoweredOn.Size = new System.Drawing.Size(69, 21);
            this.checkBoxPoweredOn.TabIndex = 8;
            this.checkBoxPoweredOn.Text = "Power";
            this.checkBoxPoweredOn.UseVisualStyleBackColor = true;
            this.checkBoxPoweredOn.CheckedChanged += new System.EventHandler(this.checkBoxPoweredOn_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Air Conditioner";
            // 
            // ctlAirConditioner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.checkBoxOnlineStatus);
            this.Controls.Add(this.checkBoxPoweredOn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ctlAirConditioner";
            this.Size = new System.Drawing.Size(359, 154);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.CheckBox checkBoxOnlineStatus;
        private System.Windows.Forms.CheckBox checkBoxPoweredOn;
        private System.Windows.Forms.Label labelFunction;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelDesired;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
    }
}

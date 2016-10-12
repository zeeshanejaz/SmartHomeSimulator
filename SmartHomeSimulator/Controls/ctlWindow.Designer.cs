namespace SmartHomeSimulator.Controls
{
    partial class ctlWindow
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
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.checkBoxOnlineStatus = new System.Windows.Forms.CheckBox();
            this.checkBoxPoweredOn = new System.Windows.Forms.CheckBox();
            this.checkBoxSafe = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelID = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.checkBoxOpen = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // checkBoxOnlineStatus
            // 
            this.checkBoxOnlineStatus.AutoSize = true;
            this.checkBoxOnlineStatus.Checked = true;
            this.checkBoxOnlineStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOnlineStatus.Location = new System.Drawing.Point(65, 228);
            this.checkBoxOnlineStatus.Name = "checkBoxOnlineStatus";
            this.checkBoxOnlineStatus.Size = new System.Drawing.Size(56, 17);
            this.checkBoxOnlineStatus.TabIndex = 4;
            this.checkBoxOnlineStatus.Text = "Online";
            this.checkBoxOnlineStatus.UseVisualStyleBackColor = true;
            this.checkBoxOnlineStatus.CheckedChanged += new System.EventHandler(this.checkBoxOnlineStatus_CheckedChanged);
            // 
            // checkBoxPoweredOn
            // 
            this.checkBoxPoweredOn.AutoSize = true;
            this.checkBoxPoweredOn.Location = new System.Drawing.Point(3, 228);
            this.checkBoxPoweredOn.Name = "checkBoxPoweredOn";
            this.checkBoxPoweredOn.Size = new System.Drawing.Size(56, 17);
            this.checkBoxPoweredOn.TabIndex = 3;
            this.checkBoxPoweredOn.Text = "Power";
            this.checkBoxPoweredOn.UseVisualStyleBackColor = true;
            this.checkBoxPoweredOn.CheckedChanged += new System.EventHandler(this.checkBoxPoweredOn_CheckedChanged);
            // 
            // checkBoxSafe
            // 
            this.checkBoxSafe.AutoSize = true;
            this.checkBoxSafe.Checked = true;
            this.checkBoxSafe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSafe.Location = new System.Drawing.Point(127, 228);
            this.checkBoxSafe.Name = "checkBoxSafe";
            this.checkBoxSafe.Size = new System.Drawing.Size(48, 17);
            this.checkBoxSafe.TabIndex = 5;
            this.checkBoxSafe.Text = "Safe";
            this.checkBoxSafe.UseVisualStyleBackColor = true;
            this.checkBoxSafe.CheckedChanged += new System.EventHandler(this.checkBoxSafe_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 209);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(240, 229);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 7;
            this.labelID.Text = "ID";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(30, 3);
            this.pictureBox.MaximumSize = new System.Drawing.Size(256, 256);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // checkBoxOpen
            // 
            this.checkBoxOpen.AutoSize = true;
            this.checkBoxOpen.Location = new System.Drawing.Point(181, 228);
            this.checkBoxOpen.Name = "checkBoxOpen";
            this.checkBoxOpen.Size = new System.Drawing.Size(52, 17);
            this.checkBoxOpen.TabIndex = 8;
            this.checkBoxOpen.Text = "Open";
            this.checkBoxOpen.UseVisualStyleBackColor = true;
            this.checkBoxOpen.CheckedChanged += new System.EventHandler(this.checkBoxOpen_CheckedChanged);
            // 
            // ctlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.checkBoxOpen);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.checkBoxSafe);
            this.Controls.Add(this.checkBoxOnlineStatus);
            this.Controls.Add(this.checkBoxPoweredOn);
            this.MinimumSize = new System.Drawing.Size(262, 250);
            this.Name = "ctlWindow";
            this.Size = new System.Drawing.Size(260, 250);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.CheckBox checkBoxOnlineStatus;
        private System.Windows.Forms.CheckBox checkBoxPoweredOn;
        private System.Windows.Forms.CheckBox checkBoxSafe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.CheckBox checkBoxOpen;
    }
}

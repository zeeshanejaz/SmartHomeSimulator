namespace SmartHomeSimulator.Controls
{
    partial class ctlBulb
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
            this.checkBoxPoweredOn = new System.Windows.Forms.CheckBox();
            this.checkBoxOnlineStatus = new System.Windows.Forms.CheckBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList.ImageSize = new System.Drawing.Size(60, 90);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // checkBoxPoweredOn
            // 
            this.checkBoxPoweredOn.AutoSize = true;
            this.checkBoxPoweredOn.Location = new System.Drawing.Point(3, 103);
            this.checkBoxPoweredOn.Name = "checkBoxPoweredOn";
            this.checkBoxPoweredOn.Size = new System.Drawing.Size(56, 17);
            this.checkBoxPoweredOn.TabIndex = 1;
            this.checkBoxPoweredOn.Text = "Power";
            this.checkBoxPoweredOn.UseVisualStyleBackColor = true;
            this.checkBoxPoweredOn.CheckedChanged += new System.EventHandler(this.checkBoxPoweredOn_CheckedChanged);
            // 
            // checkBoxOnlineStatus
            // 
            this.checkBoxOnlineStatus.AutoSize = true;
            this.checkBoxOnlineStatus.Checked = true;
            this.checkBoxOnlineStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOnlineStatus.Location = new System.Drawing.Point(68, 103);
            this.checkBoxOnlineStatus.Name = "checkBoxOnlineStatus";
            this.checkBoxOnlineStatus.Size = new System.Drawing.Size(56, 17);
            this.checkBoxOnlineStatus.TabIndex = 2;
            this.checkBoxOnlineStatus.Text = "Online";
            this.checkBoxOnlineStatus.UseVisualStyleBackColor = true;
            this.checkBoxOnlineStatus.CheckedChanged += new System.EventHandler(this.checkBoxOnlineStatus_CheckedChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(165, 97);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(144, 103);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID";
            // 
            // ctlBulb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.checkBoxOnlineStatus);
            this.Controls.Add(this.checkBoxPoweredOn);
            this.Controls.Add(this.pictureBox);
            this.MinimumSize = new System.Drawing.Size(125, 125);
            this.Name = "ctlBulb";
            this.Size = new System.Drawing.Size(165, 123);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox checkBoxPoweredOn;
        private System.Windows.Forms.CheckBox checkBoxOnlineStatus;
        private System.Windows.Forms.Label labelID;
    }
}

namespace SmartHomeSimulator.Controls
{
    partial class ctlCDPlayer
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.checkBoxOnlineStatus = new System.Windows.Forms.CheckBox();
            this.checkBoxPoweredOn = new System.Windows.Forms.CheckBox();
            this.labelID = new System.Windows.Forms.Label();
            this.pictureBoxPrev = new System.Windows.Forms.PictureBox();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.pictureBoxStop = new System.Windows.Forms.PictureBox();
            this.pictureBoxPause = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList.ImageSize = new System.Drawing.Size(57, 57);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelStatus
            // 
            this.labelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(0, 0);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(464, 35);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Powered Off";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxOnlineStatus
            // 
            this.checkBoxOnlineStatus.AutoSize = true;
            this.checkBoxOnlineStatus.Checked = true;
            this.checkBoxOnlineStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOnlineStatus.Location = new System.Drawing.Point(87, 127);
            this.checkBoxOnlineStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxOnlineStatus.Name = "checkBoxOnlineStatus";
            this.checkBoxOnlineStatus.Size = new System.Drawing.Size(71, 21);
            this.checkBoxOnlineStatus.TabIndex = 8;
            this.checkBoxOnlineStatus.Text = "Online";
            this.checkBoxOnlineStatus.UseVisualStyleBackColor = true;
            this.checkBoxOnlineStatus.CheckedChanged += new System.EventHandler(this.checkBoxOnlineStatus_CheckedChanged);
            // 
            // checkBoxPoweredOn
            // 
            this.checkBoxPoweredOn.AutoSize = true;
            this.checkBoxPoweredOn.Location = new System.Drawing.Point(4, 127);
            this.checkBoxPoweredOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPoweredOn.Name = "checkBoxPoweredOn";
            this.checkBoxPoweredOn.Size = new System.Drawing.Size(69, 21);
            this.checkBoxPoweredOn.TabIndex = 7;
            this.checkBoxPoweredOn.Text = "Power";
            this.checkBoxPoweredOn.UseVisualStyleBackColor = true;
            this.checkBoxPoweredOn.CheckedChanged += new System.EventHandler(this.checkBoxPoweredOn_CheckedChanged);
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(437, 128);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 10;
            this.labelID.Text = "ID";
            // 
            // pictureBoxPrev
            // 
            this.pictureBoxPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPrev.Location = new System.Drawing.Point(25, 43);
            this.pictureBoxPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPrev.Name = "pictureBoxPrev";
            this.pictureBoxPrev.Size = new System.Drawing.Size(76, 70);
            this.pictureBoxPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPrev.TabIndex = 16;
            this.pictureBoxPrev.TabStop = false;
            this.pictureBoxPrev.Click += new System.EventHandler(this.pictureBoxPrev_Click);
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxNext.Location = new System.Drawing.Point(109, 43);
            this.pictureBoxNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(76, 70);
            this.pictureBoxNext.TabIndex = 15;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPlay.Location = new System.Drawing.Point(193, 43);
            this.pictureBoxPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(76, 70);
            this.pictureBoxPlay.TabIndex = 14;
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            // 
            // pictureBoxStop
            // 
            this.pictureBoxStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxStop.Location = new System.Drawing.Point(277, 43);
            this.pictureBoxStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxStop.Name = "pictureBoxStop";
            this.pictureBoxStop.Size = new System.Drawing.Size(76, 70);
            this.pictureBoxStop.TabIndex = 13;
            this.pictureBoxStop.TabStop = false;
            this.pictureBoxStop.Click += new System.EventHandler(this.pictureBoxStop_Click);
            // 
            // pictureBoxPause
            // 
            this.pictureBoxPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPause.Location = new System.Drawing.Point(361, 43);
            this.pictureBoxPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPause.Name = "pictureBoxPause";
            this.pictureBoxPause.Size = new System.Drawing.Size(76, 70);
            this.pictureBoxPause.TabIndex = 12;
            this.pictureBoxPause.TabStop = false;
            this.pictureBoxPause.Click += new System.EventHandler(this.pictureBoxPause_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Media Player";
            // 
            // ctlCDPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxPrev);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.pictureBoxPlay);
            this.Controls.Add(this.pictureBoxStop);
            this.Controls.Add(this.pictureBoxPause);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.checkBoxOnlineStatus);
            this.Controls.Add(this.checkBoxPoweredOn);
            this.Controls.Add(this.labelStatus);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(466, 153);
            this.Name = "ctlCDPlayer";
            this.Size = new System.Drawing.Size(464, 151);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.CheckBox checkBoxOnlineStatus;
        private System.Windows.Forms.CheckBox checkBoxPoweredOn;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.PictureBox pictureBoxPrev;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.PictureBox pictureBoxStop;
        private System.Windows.Forms.PictureBox pictureBoxPause;
        private System.Windows.Forms.Label label1;
    }
}

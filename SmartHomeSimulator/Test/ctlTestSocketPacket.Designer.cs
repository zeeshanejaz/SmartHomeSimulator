namespace SmartHomeSimulator.Test
{
    partial class ctlTestSocketPacket
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
            this.labelPacket = new System.Windows.Forms.Label();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPacket
            // 
            this.labelPacket.AutoSize = true;
            this.labelPacket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacket.Location = new System.Drawing.Point(3, 36);
            this.labelPacket.Name = "labelPacket";
            this.labelPacket.Size = new System.Drawing.Size(47, 15);
            this.labelPacket.TabIndex = 16;
            this.labelPacket.Text = "Packet:";
            // 
            // textBoxTest
            // 
            this.textBoxTest.AcceptsReturn = true;
            this.textBoxTest.AcceptsTab = true;
            this.textBoxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTest.Location = new System.Drawing.Point(64, 33);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(310, 21);
            this.textBoxTest.TabIndex = 3;
            this.textBoxTest.Text = "|request|device|execute|gettextstatus|1|";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(380, 32);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(47, 23);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(6, 6);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(82, 23);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(94, 6);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(82, 23);
            this.buttonDisconnect.TabIndex = 6;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(3, 59);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(110, 15);
            this.labelResult.TabIndex = 17;
            this.labelResult.Text = "See results in logs.";
            // 
            // ctlTestSocketPacket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelPacket);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.buttonTest);
            this.Name = "ctlTestSocketPacket";
            this.Size = new System.Drawing.Size(477, 92);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPacket;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelResult;
    }
}

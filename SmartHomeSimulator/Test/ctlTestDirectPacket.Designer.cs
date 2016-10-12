namespace SmartHomeSimulator
{
    partial class ctlTestDirectPacket
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
            this.labelResult = new System.Windows.Forms.Label();
            this.labelPacket = new System.Windows.Forms.Label();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(3, 31);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(45, 15);
            this.labelResult.TabIndex = 13;
            this.labelResult.Text = "Result:";
            // 
            // labelPacket
            // 
            this.labelPacket.AutoSize = true;
            this.labelPacket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacket.Location = new System.Drawing.Point(3, 8);
            this.labelPacket.Name = "labelPacket";
            this.labelPacket.Size = new System.Drawing.Size(47, 15);
            this.labelPacket.TabIndex = 12;
            this.labelPacket.Text = "Packet:";
            // 
            // textBoxTest
            // 
            this.textBoxTest.AcceptsReturn = true;
            this.textBoxTest.AcceptsTab = true;
            this.textBoxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTest.Location = new System.Drawing.Point(64, 5);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(310, 21);
            this.textBoxTest.TabIndex = 1;
            this.textBoxTest.Text = "|request|device|execute|gettextstatus|1|";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(380, 4);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(47, 23);
            this.buttonTest.TabIndex = 2;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // ctlTestDirectPacket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelPacket);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.buttonTest);
            this.Name = "ctlTestDirectPacket";
            this.Size = new System.Drawing.Size(488, 73);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelPacket;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.Button buttonTest;
    }
}

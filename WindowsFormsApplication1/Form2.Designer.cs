namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.currentTime = new System.Windows.Forms.Label();
            this.currentBlind = new System.Windows.Forms.Label();
            this.nextBlind = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.Location = new System.Drawing.Point(60, 53);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(164, 42);
            this.currentTime.TabIndex = 0;
            this.currentTime.Text = "00:00:00";
            this.currentTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentBlind
            // 
            this.currentBlind.AutoSize = true;
            this.currentBlind.Location = new System.Drawing.Point(109, 24);
            this.currentBlind.Name = "currentBlind";
            this.currentBlind.Size = new System.Drawing.Size(64, 13);
            this.currentBlind.TabIndex = 1;
            this.currentBlind.Text = "CurrentBlind";
            this.currentBlind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nextBlind
            // 
            this.nextBlind.AutoSize = true;
            this.nextBlind.Location = new System.Drawing.Point(109, 118);
            this.nextBlind.Name = "nextBlind";
            this.nextBlind.Size = new System.Drawing.Size(55, 13);
            this.nextBlind.TabIndex = 2;
            this.nextBlind.Text = "Next Blind";
            this.nextBlind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.nextBlind);
            this.Controls.Add(this.currentBlind);
            this.Controls.Add(this.currentTime);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label currentBlind;
        private System.Windows.Forms.Label nextBlind;
    }
}
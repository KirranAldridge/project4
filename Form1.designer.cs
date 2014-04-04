namespace AntiVirus
{
    partial class Form1
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
            this.scan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VirusesFound = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // scan
            // 
            this.scan.Location = new System.Drawing.Point(243, 10);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(75, 23);
            this.scan.TabIndex = 0;
            this.scan.Text = "Scan";
            this.scan.UseVisualStyleBackColor = true;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Viruses Found:";
            // 
            // VirusesFound
            // 
            this.VirusesFound.AutoSize = true;
            this.VirusesFound.Location = new System.Drawing.Point(12, 88);
            this.VirusesFound.Name = "VirusesFound";
            this.VirusesFound.Size = new System.Drawing.Size(35, 13);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(12, 228);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(37, 13);
            this.Message.TabIndex = 3;
            this.Message.Text = "Status";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 269);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.VirusesFound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VirusesFound;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}


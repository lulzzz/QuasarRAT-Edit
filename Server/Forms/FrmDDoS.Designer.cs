namespace xServer.Forms
{
    partial class FrmDDoS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDDoS));
            this.lblURL = new System.Windows.Forms.Label();
            this.txtip = new System.Windows.Forms.TextBox();
            this.btnDownloadAndExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(9, 15);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(20, 13);
            this.lblURL.TabIndex = 4;
            this.lblURL.Text = "IP:";
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(35, 12);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(205, 20);
            this.txtip.TabIndex = 5;
            this.txtip.Text = "127.0.0.1";
            // 
            // btnDownloadAndExecute
            // 
            this.btnDownloadAndExecute.Location = new System.Drawing.Point(117, 38);
            this.btnDownloadAndExecute.Name = "btnDownloadAndExecute";
            this.btnDownloadAndExecute.Size = new System.Drawing.Size(123, 23);
            this.btnDownloadAndExecute.TabIndex = 7;
            this.btnDownloadAndExecute.Text = "Attack";
            this.btnDownloadAndExecute.UseVisualStyleBackColor = true;
            this.btnDownloadAndExecute.Click += new System.EventHandler(this.btnDownloadAndExecute_Click);
            // 
            // FrmDDoS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 71);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.btnDownloadAndExecute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDDoS";
            this.Text = "FrmDDoS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Button btnDownloadAndExecute;

    }
}
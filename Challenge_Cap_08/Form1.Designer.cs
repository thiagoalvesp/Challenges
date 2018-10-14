namespace Challenge_Cap_08
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDownloadNormal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 17);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(23, 13);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "Url:";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(537, 12);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(110, 23);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download Aysnc";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(41, 14);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(490, 20);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.Text = "https://speed.hetzner.de/100MB.bin";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(12, 59);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(776, 382);
            this.lblResult.TabIndex = 3;
            // 
            // btnDownloadNormal
            // 
            this.btnDownloadNormal.Location = new System.Drawing.Point(653, 12);
            this.btnDownloadNormal.Name = "btnDownloadNormal";
            this.btnDownloadNormal.Size = new System.Drawing.Size(110, 23);
            this.btnDownloadNormal.TabIndex = 4;
            this.btnDownloadNormal.Text = "Download";
            this.btnDownloadNormal.UseVisualStyleBackColor = true;
            this.btnDownloadNormal.Click += new System.EventHandler(this.btnDownloadNormal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDownloadNormal);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblUrl);
            this.Name = "Form1";
            this.Text = "Challenge08";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDownloadNormal;
    }
}


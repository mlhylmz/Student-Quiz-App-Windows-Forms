namespace DenemeForm
{
    partial class ogrenciSonuc
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
            this.toplamSoruLabel = new System.Windows.Forms.Label();
            this.DogruLabel = new System.Windows.Forms.Label();
            this.yanlisLabel = new System.Windows.Forms.Label();
            this.bosSayiLabel = new System.Windows.Forms.Label();
            this.netSayiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toplamSoruLabel
            // 
            this.toplamSoruLabel.AutoSize = true;
            this.toplamSoruLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toplamSoruLabel.Location = new System.Drawing.Point(12, 29);
            this.toplamSoruLabel.Name = "toplamSoruLabel";
            this.toplamSoruLabel.Size = new System.Drawing.Size(299, 32);
            this.toplamSoruLabel.TabIndex = 0;
            this.toplamSoruLabel.Text = "Toplam Çıkan Soru Sayısı : ";
            // 
            // DogruLabel
            // 
            this.DogruLabel.AutoSize = true;
            this.DogruLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DogruLabel.Location = new System.Drawing.Point(12, 111);
            this.DogruLabel.Name = "DogruLabel";
            this.DogruLabel.Size = new System.Drawing.Size(166, 32);
            this.DogruLabel.TabIndex = 1;
            this.DogruLabel.Text = "Doğru Sayısı : ";
            // 
            // yanlisLabel
            // 
            this.yanlisLabel.AutoSize = true;
            this.yanlisLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yanlisLabel.Location = new System.Drawing.Point(12, 143);
            this.yanlisLabel.Name = "yanlisLabel";
            this.yanlisLabel.Size = new System.Drawing.Size(158, 32);
            this.yanlisLabel.TabIndex = 2;
            this.yanlisLabel.Text = "Yanlış Sayısı : ";
            // 
            // bosSayiLabel
            // 
            this.bosSayiLabel.AutoSize = true;
            this.bosSayiLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bosSayiLabel.Location = new System.Drawing.Point(12, 175);
            this.bosSayiLabel.Name = "bosSayiLabel";
            this.bosSayiLabel.Size = new System.Drawing.Size(137, 32);
            this.bosSayiLabel.TabIndex = 3;
            this.bosSayiLabel.Text = "Boş Sayısı : ";
            // 
            // netSayiLabel
            // 
            this.netSayiLabel.AutoSize = true;
            this.netSayiLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.netSayiLabel.Location = new System.Drawing.Point(12, 251);
            this.netSayiLabel.Name = "netSayiLabel";
            this.netSayiLabel.Size = new System.Drawing.Size(170, 41);
            this.netSayiLabel.TabIndex = 4;
            this.netSayiLabel.Text = "Net Sayısı : ";
            // 
            // ogrenciSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.netSayiLabel);
            this.Controls.Add(this.bosSayiLabel);
            this.Controls.Add(this.yanlisLabel);
            this.Controls.Add(this.DogruLabel);
            this.Controls.Add(this.toplamSoruLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ogrenciSonuc";
            this.Text = "ogrenciSonuc";
            this.Load += new System.EventHandler(this.ogrenciSonuc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label toplamSoruLabel;
        private Label DogruLabel;
        private Label yanlisLabel;
        private Label bosSayiLabel;
        private Label netSayiLabel;
    }
}
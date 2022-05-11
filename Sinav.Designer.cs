namespace DenemeForm
{
    partial class Sinav
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.sinavKaydetBtn = new System.Windows.Forms.Button();
            this.suAnkiSureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz süresiniz seçiniz : ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(144, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(121, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "7 Dakika 20 Saniye";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(280, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "10 Dakika";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(373, 38);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(127, 19);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "12 Dakika 30 Saniye";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // sinavKaydetBtn
            // 
            this.sinavKaydetBtn.Location = new System.Drawing.Point(280, 87);
            this.sinavKaydetBtn.Name = "sinavKaydetBtn";
            this.sinavKaydetBtn.Size = new System.Drawing.Size(75, 23);
            this.sinavKaydetBtn.TabIndex = 4;
            this.sinavKaydetBtn.Text = "KAYDET";
            this.sinavKaydetBtn.UseVisualStyleBackColor = true;
            this.sinavKaydetBtn.Click += new System.EventHandler(this.sinavKaydetBtn_Click);
            // 
            // suAnkiSureLabel
            // 
            this.suAnkiSureLabel.AutoSize = true;
            this.suAnkiSureLabel.Location = new System.Drawing.Point(14, 13);
            this.suAnkiSureLabel.Name = "suAnkiSureLabel";
            this.suAnkiSureLabel.Size = new System.Drawing.Size(117, 15);
            this.suAnkiSureLabel.TabIndex = 5;
            this.suAnkiSureLabel.Text = "Şu an ki Quiz süresi : ";
            // 
            // Sinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 178);
            this.Controls.Add(this.suAnkiSureLabel);
            this.Controls.Add(this.sinavKaydetBtn);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Sinav";
            this.Text = "Sınav Sorumlusu";
            this.Load += new System.EventHandler(this.Sinav_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button sinavKaydetBtn;
        private Label suAnkiSureLabel;
    }
}
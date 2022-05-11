namespace DenemeForm
{
    partial class Admin
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
            this.randNoLabel = new System.Windows.Forms.Label();
            this.adminSaveBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // randNoLabel
            // 
            this.randNoLabel.AutoSize = true;
            this.randNoLabel.Location = new System.Drawing.Point(44, 42);
            this.randNoLabel.Name = "randNoLabel";
            this.randNoLabel.Size = new System.Drawing.Size(148, 15);
            this.randNoLabel.TabIndex = 0;
            this.randNoLabel.Text = "Mevcut Havuz Soru Sayısı :";
            // 
            // adminSaveBtn
            // 
            this.adminSaveBtn.Location = new System.Drawing.Point(44, 123);
            this.adminSaveBtn.Name = "adminSaveBtn";
            this.adminSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.adminSaveBtn.TabIndex = 1;
            this.adminSaveBtn.Text = "Kaydet";
            this.adminSaveBtn.UseVisualStyleBackColor = true;
            this.adminSaveBtn.Click += new System.EventHandler(this.adminSaveBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 183);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.adminSaveBtn);
            this.Controls.Add(this.randNoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label randNoLabel;
        private Button adminSaveBtn;
        private ComboBox comboBox1;
    }
}
namespace DenemeForm
{
    partial class Login
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
            this.adminBox = new System.Windows.Forms.CheckBox();
            this.ogrenciCheck = new System.Windows.Forms.CheckBox();
            this.sinavCheck = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kayitBtn = new System.Windows.Forms.Button();
            this.sifreUnutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminBox
            // 
            this.adminBox.AutoSize = true;
            this.adminBox.Location = new System.Drawing.Point(147, 349);
            this.adminBox.Name = "adminBox";
            this.adminBox.Size = new System.Drawing.Size(62, 19);
            this.adminBox.TabIndex = 0;
            this.adminBox.Text = "Admin";
            this.adminBox.UseVisualStyleBackColor = true;
            this.adminBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ogrenciCheck
            // 
            this.ogrenciCheck.AutoSize = true;
            this.ogrenciCheck.Location = new System.Drawing.Point(67, 349);
            this.ogrenciCheck.Name = "ogrenciCheck";
            this.ogrenciCheck.Size = new System.Drawing.Size(68, 19);
            this.ogrenciCheck.TabIndex = 1;
            this.ogrenciCheck.Text = "Öğrenci";
            this.ogrenciCheck.UseVisualStyleBackColor = true;
            this.ogrenciCheck.CheckedChanged += new System.EventHandler(this.ogrenciCheck_CheckedChanged);
            // 
            // sinavCheck
            // 
            this.sinavCheck.AutoSize = true;
            this.sinavCheck.Location = new System.Drawing.Point(83, 374);
            this.sinavCheck.Name = "sinavCheck";
            this.sinavCheck.Size = new System.Drawing.Size(114, 19);
            this.sinavCheck.TabIndex = 2;
            this.sinavCheck.Text = "Sınav Sorumlusu";
            this.sinavCheck.UseVisualStyleBackColor = true;
            this.sinavCheck.CheckedChanged += new System.EventHandler(this.sinavCheck_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 23);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sınav Soru Sistemi";
            // 
            // kayitBtn
            // 
            this.kayitBtn.Location = new System.Drawing.Point(67, 249);
            this.kayitBtn.Name = "kayitBtn";
            this.kayitBtn.Size = new System.Drawing.Size(142, 23);
            this.kayitBtn.TabIndex = 9;
            this.kayitBtn.Text = "Öğrenci Kayıt Ol";
            this.kayitBtn.UseVisualStyleBackColor = true;
            this.kayitBtn.Click += new System.EventHandler(this.kayitBtn_Click);
            // 
            // sifreUnutBtn
            // 
            this.sifreUnutBtn.Location = new System.Drawing.Point(67, 292);
            this.sifreUnutBtn.Name = "sifreUnutBtn";
            this.sifreUnutBtn.Size = new System.Drawing.Size(142, 23);
            this.sifreUnutBtn.TabIndex = 10;
            this.sifreUnutBtn.Text = "Şifremi Unuttum";
            this.sifreUnutBtn.UseVisualStyleBackColor = true;
            this.sifreUnutBtn.Click += new System.EventHandler(this.sifreUnutBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 405);
            this.Controls.Add(this.sifreUnutBtn);
            this.Controls.Add(this.kayitBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sinavCheck);
            this.Controls.Add(this.ogrenciCheck);
            this.Controls.Add(this.adminBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox adminBox;
        private CheckBox ogrenciCheck;
        private CheckBox sinavCheck;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button kayitBtn;
        private Button sifreUnutBtn;
    }
}
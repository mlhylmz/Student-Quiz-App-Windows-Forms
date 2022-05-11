using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DenemeForm
{
    public partial class Login : Form
    {
        Class1 cl = new Class1();


        string choice = "default";
        
        public Login()
        {
            InitializeComponent();
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            choice = "admin";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (radioButton1.Checked && textBox1.Text == cl.getogrenciUsername() && textBox2.Text == cl.getogrenciPassword())
                {
                    MessageBox.Show("Öğrenci Girişi Yapıldı");
                    Ogrenci ogrenciForm = new Ogrenci();
                    ogrenciForm.Show();
                }
                else if ( radioButton2.Checked && textBox1.Text == cl.getadminUserName() && textBox2.Text == cl.getadminPassword())
                {
                    MessageBox.Show("Admin girişi yapıldı");
                    Admin adminForm = new Admin();
                    adminForm.Show();
                    
                }
                else if (radioButton3.Checked && textBox1.Text == cl.getSorumluUsername() && textBox2.Text == cl.getSorumluPassword() )
                {
                    MessageBox.Show("Sorumlu girişi yapıldı.");
                    Sinav sinavSorumlu = new Sinav();
                    sinavSorumlu.ShowDialog();
                    
                    
                }
                else if (radioButton1.Checked && textBox1.Text == cl.getogrenci2UserName() && textBox2.Text == cl.getogrenci2Password())
                {
                    MessageBox.Show("öğrenci 2");
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı , Şifre Veya Seçim Hatalı");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            else {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifrenizi Giriniz"); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void sifreUnutBtn_Click(object sender, EventArgs e)
        {
            if (choice == "öğrenci" && textBox1.Text == cl.getogrenciUsername())
            {
                _ = MessageBox.Show("Şifreniz : " + cl.getogrenciPassword());
            }
            else if (choice == "admin" && textBox1.Text == cl.getadminUserName())
            {
                _ = MessageBox.Show("Şifreniz : " + cl.getadminPassword());
            }
            else if (choice == "sorumlu" && textBox1.Text == cl.getSorumluUsername())
            {
                _ = MessageBox.Show("Şifreniz : " + cl.getSorumluPassword());
            }
            else if (choice == "öğrenci" && textBox1.Text == cl.getogrenci2UserName())
            {
                _ = MessageBox.Show("Şifreniz : " + cl.getogrenci2Password());
            }
            else
            {
                MessageBox.Show("Kullanıcı adınızı girip tipinizi seçiniz.");
            }
        }

        public void kayitBtn_Click(object sender, EventArgs e)
        {
            cl.setOgrenci2UserName(textBox1.Text);
            cl.setOgrenci2Password(textBox2.Text);
            _ = MessageBox.Show("Kayıt Başarılı\nKullanıcı Adı : " + cl.getogrenci2UserName() + "\nŞifreniz : " + cl.getogrenci2Password());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void melihBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "melih";
            textBox2.Text = "melih123";
            radioButton1.Checked = true;
        }

        private void adminBtn_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "admin";
            textBox2.Text = "admin123";
            radioButton2.Checked = true;
        }

        private void sorumluBtn_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "sorumlu";
            textBox2.Text = "sorumlu123";
            radioButton3.Checked = true;
        }
    }
}

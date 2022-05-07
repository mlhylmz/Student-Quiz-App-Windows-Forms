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
                if (choice == "öğrenci" && textBox1.Text == cl.getogrenciUsername() && textBox2.Text == cl.getogrenciPassword())
                {
                    MessageBox.Show("Öğrenci Girişi Yapıldı");
                    Admin adminForm = new Admin();
                    adminForm.Show();
                }
                else if (choice == "admin" && textBox1.Text == cl.getadminUserName() && textBox2.Text == cl.getadminPassword())
                {
                    MessageBox.Show("Admin girişi yapıldı");
                    
                }
                else if (choice == "sorumlu" && textBox1.Text == cl.getSorumluUsername() && textBox2.Text == cl.getSorumluPassword() )
                {
                    MessageBox.Show("Sorumlu girişi yapıldı.");
                    Sinav sinavSorumlu = new Sinav();
                    sinavSorumlu.ShowDialog();
                    
                    
                }
                else if (choice == "öğrenci" && textBox1.Text == cl.getogrenci2UserName() && textBox2.Text == cl.getogrenci2Password())
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

        public void ogrenciCheck_CheckedChanged(object sender, EventArgs e)
        {
            choice = "öğrenci";
        }

        public void sinavCheck_CheckedChanged(object sender, EventArgs e)
        {
            choice = "sorumlu";
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
    }
}

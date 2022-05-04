using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace DenemeForm
{
    public partial class Login : Form
    {

        string choice = "default";
        string ogrenciUserName = "melih";
        string ogrenciPassword = "melih123";

        string ogrenci2UserName = "default";
        string ogrenci2Password = "default";
        
        string adminUserName = "admin";
        string adminPassword = "admin123";

        string sorumluUsername = "sorumlu";
        string sorumluPassword = "sorumlu123";
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
                if (choice == "öğrenci" && textBox1.Text == ogrenciUserName && textBox2.Text == ogrenciPassword)
                {
                    MessageBox.Show("Öğrenci");
                }
                else if (choice == "admin" && textBox1.Text == adminUserName && textBox2.Text == adminPassword)
                {
                    MessageBox.Show("Admin girişi yapıldı");
                    Admin adminForm = new Admin(); //this is the change, code for redirect  
                    adminForm.ShowDialog();
                }
                else if (choice == "sorumlu" && textBox1.Text == sorumluUsername && textBox2.Text == sorumluPassword)
                {
                    MessageBox.Show("Sorumlu girişi yapıldı.");
                }
                else if (choice == "öğrenci" && textBox1.Text == ogrenci2UserName && textBox2.Text == ogrenci2Password)
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
            if (choice == "öğrenci" && textBox1.Text == ogrenciUserName)
            {
                _ = MessageBox.Show("Şifreniz : " + ogrenciPassword);
            }
            else if (choice == "admin" && textBox1.Text == adminUserName)
            {
                _ = MessageBox.Show("Şifreniz : " + adminPassword);
            }
            else if (choice == "sorumlu" && textBox1.Text == sorumluUsername)
            {
                _ = MessageBox.Show("Şifreniz : " + sorumluPassword);
            }
            else if (choice == "öğrenci" && textBox1.Text == ogrenci2UserName)
            {
                _ = MessageBox.Show("Şifreniz : " + ogrenci2Password);
            }
            else
            {
                MessageBox.Show("Kullanıcı adınızı girip tipinizi seçiniz.");
            }
        }

        public void kayitBtn_Click(object sender, EventArgs e)
        {
            ogrenci2UserName = textBox1.Text;
            ogrenci2Password = textBox2.Text;
            _ = MessageBox.Show("Kayıt Başarılı\nKullanıcı Adı : " + ogrenci2UserName + "\nŞifreniz : " + ogrenci2Password);
        }
    }
}

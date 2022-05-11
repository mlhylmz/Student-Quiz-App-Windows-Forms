using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenemeForm
{
    public partial class Admin : Form
    {   
        Class1 cl = new Class1();
        public string temp = "default";
        
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("10");
            comboBox1.Items.Add("25");
            comboBox1.Items.Add("50");
            comboBox1.Items.Add("75");
            comboBox1.Items.Add("100");
            randNoLabel.Text = "Mevcut Havuz Soru Sayısı : "+cl.getMaxRandomNumber().ToString();
        }

        private void adminSaveBtn_Click(object sender, EventArgs e)
        {
            temp = (string)comboBox1.SelectedItem;
            cl.setRandomNo(Int32.Parse(comboBox1.SelectedItem.ToString()));
            
            randNoLabel.Text="Yeni Havuz Soru Sayısı : "+cl.getMaxRandomNumber().ToString();
            MessageBox.Show("Kaydedildi");
            this.Close();
            GC.Collect();
        }
    }
}

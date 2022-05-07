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
    public partial class Sinav : Form
    {   
        Class1 cl1 = new Class1();
        public Sinav()
        {
            InitializeComponent();
        }

        public void sinavKaydetBtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cl1.setTimerSec(420);
                MessageBox.Show("Kaydedildi");
                this.Close();
                GC.Collect();
                ///MessageBox.Show(cl1.getTimerSec);
            }
            else if (radioButton2.Checked)
            {
                cl1.setTimerSec(600);
                MessageBox.Show("Kaydedildi");
                this.Close();
                GC.Collect();

            }
            else if (radioButton3.Checked)
            {
                cl1.setTimerSec(720);
                MessageBox.Show("Kaydedildi");
                this.Close();
                GC.Collect();
            }
        }
    }
}

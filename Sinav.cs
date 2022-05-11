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
        public static int timer = 420;
        public Sinav()
        {
            InitializeComponent();
        }

        public void sinavKaydetBtn_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                setTimerSec(440);
                MessageBox.Show("Kaydedildi. Yeni Süre : " + getTimerSecText());
                this.Close();
                GC.Collect();
            }
            else if (radioButton2.Checked)
            {
                setTimerSec(600);
                MessageBox.Show("Kaydedildi. Yeni Süre : " + getTimerSecText());
                this.Close();
                GC.Collect();

            }
            else if (radioButton3.Checked)
            {
                setTimerSec(750);
                MessageBox.Show("Kaydedildi. Yeni Süre : " + getTimerSecText());
                this.Close();
                GC.Collect();
            }
        }

        public int getTimerSec() {
            return timer;
        }
        public string getTimerSecText() {
            int sec = getTimerSec();
            string minsec = (sec/60).ToString()+ " Dakika   "+(sec%60).ToString()+ " Saniye";
            return minsec;
        }
        public static void setTimerSec(int time)
        {
            timer = time;
        }

        private void Sinav_Load(object sender, EventArgs e)
        {
            suAnkiSureLabel.Text = "Şu an ki Quiz süresi : "+ getTimerSecText();
        }
    }
}

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
    public partial class Ogrenci : Form
    {
        Class1 cl = new Class1();
        Sinav sn = new Sinav();
        public int TempId = 1;
        public string currentAnswer = "default";
        public int rightAnswerCounter = 0;
        public int wrongAnswerCounter = 0;
        public int emptyAnswerCounter = 0;
        public int ort = 0;
        public int Seconds { get; set; }

        public Ogrenci()
        {
            InitializeComponent();
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            setSeconds(sn.getTimerSec());
            timer1.Start();
            tempLabel.Text = cl.getMaxRandomNumber().ToString();
            

            ///     DOĞRU CEVAPLANAN SORULAR
            if (radioButton1.Checked && currentAnswer == "A")
            {
                setRight(1);
                MessageBox.Show("Doğru");
                radioButton1.Checked = false;
                label1.Text = "Doğru Sayısı : " + rightAnswerCounter.ToString();
            }
            else if (radioButton2.Checked && currentAnswer == "B")
            {
                setRight(1);
                MessageBox.Show("Doğru");
                radioButton2.Checked = false;
                label1.Text = "Doğru Sayısı : " + rightAnswerCounter.ToString();
            }
            else if (radioButton3.Checked && currentAnswer == "C")
            {
                setRight(1);
                MessageBox.Show("Doğru");
                radioButton3.Checked = false;
                label1.Text = "Doğru Sayısı : " + rightAnswerCounter.ToString();
            }
            else if (radioButton4.Checked && currentAnswer == "D")
            {
                setRight(1);
                MessageBox.Show("Doğru");
                radioButton4.Checked = false;
                label1.Text = "Doğru Sayısı : " + rightAnswerCounter.ToString();
            }
            else if (currentAnswer == "default")
            {
                MessageBox.Show("Başla");
            }

            ///     YANLIŞ CEVAPLANAN SORULAR
            else if (radioButton1.Checked && currentAnswer != "A")
            {
                setWrong(1);
                MessageBox.Show("Yanlış");
                radioButton1.Checked = false;
                label2.Text = "Yanlış Sayısı : " + wrongAnswerCounter.ToString();
            }
            else if (radioButton2.Checked && currentAnswer != "B")
            {
                setWrong(1);
                MessageBox.Show("Yanlış");
                radioButton2.Checked = false;
                label2.Text = "Yanlış Sayısı : " + wrongAnswerCounter.ToString();
            }
            else if (radioButton3.Checked && currentAnswer != "C")
            {
                setWrong(1);
                MessageBox.Show("Yanlış");
                radioButton3.Checked = false;
                label2.Text = "Yanlış Sayısı : " + wrongAnswerCounter.ToString();
            }
            else if (radioButton4.Checked && currentAnswer != "D")
            {
                setWrong(1);
                MessageBox.Show("Yanlış");
                radioButton4.Checked = false;
                label2.Text = "Yanlış Sayısı : " + wrongAnswerCounter.ToString();
            }

            ///     BOŞ BIRAKILAN SORULAR
            else
            {
                MessageBox.Show("Boş bırakıldı");
                setEmpty(1);
                label4.Text = "Boş Sayısı : " + emptyAnswerCounter.ToString();

            }

            ort = rightAnswerCounter - (wrongAnswerCounter / 3);
            label3.Text = "Net Sayısı : " + ort.ToString();




            TempId = cl.randNumber();
            pictureBox2.Image = Image.FromFile("c:\\Sorular\\" + TempId.ToString() + ".jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            currentAnswer = cl.getAns(TempId);

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = "Kalan Zaman : " + (Seconds/60).ToString() + " Dakika  "+ (Seconds %60)+"Saniye";
            if (Seconds < 0)
            {
                timer1.Stop();

                ///this.Close();
                ///ogrenciSonuc sonuc = new ogrenciSonuc();
                ///sonuc.Show();

                MessageBox.Show("Zaman Bitti. Sonuçlar...\n\nToplam Soru Sayısı : " + getToplam().ToString() + "\n\nDoğru Sayısı : " + getRight().ToString() + 
                    "\n\nYanlış Sayısı : " + getWrong().ToString()
                    + "\n\nBoş Sayısı : " + getEmpty().ToString() + "\n\nNet Sayısı : " + getOrt().ToString());

            }
            Seconds--;
        }

        private void adminKapatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
        }
        public int getWrong(){return wrongAnswerCounter; }
        public int getRight() { return rightAnswerCounter; }

        public int getEmpty() { return emptyAnswerCounter; }

        public int getOrt() { return ort; }

        public int getToplam() { return wrongAnswerCounter + rightAnswerCounter + emptyAnswerCounter; }

        public void setWrong(int num) { this.wrongAnswerCounter = this.wrongAnswerCounter + num; }

        public void setRight(int num) { this.rightAnswerCounter = this.rightAnswerCounter + num; }

        public void setEmpty(int num) { this.emptyAnswerCounter = this.emptyAnswerCounter + num; }
        public void setSeconds(int num) { this.Seconds = num; }

    }
}

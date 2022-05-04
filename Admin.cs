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
using System.IO;

namespace DenemeForm
{
    public partial class Admin : Form
    {
        Class1 cl = new Class1();
        public int TempId = 1;
        public string currentAnswer = "default";
        public int rightAnswerCounter = 0;
        public int wrongAnswerCounter = 0;
        public int ort = 0;

        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            ///     DOĞRU CEVAPLANAN SORULAR
            if (radioButton1.Checked && currentAnswer == "A")
            {
                rightAnswerCounter++;
                MessageBox.Show("Doğru");
                radioButton1.Checked = false;
                label1.Text = "Doğru Sayısı : " + rightAnswerCounter.ToString();
            }
            else if (radioButton2.Checked && currentAnswer == "B")
            {
                rightAnswerCounter++;
                MessageBox.Show("Doğru");
                radioButton2.Checked = false;
                label1.Text = "Doğru Sayısı : " + rightAnswerCounter.ToString();
            }
            else if (radioButton3.Checked && currentAnswer == "C")
            {
                rightAnswerCounter++;
                MessageBox.Show("Doğru");
                radioButton3.Checked = false;
                label1.Text = "Doğru Sayısı : " + rightAnswerCounter.ToString();
            }
            else if (radioButton4.Checked && currentAnswer == "D")
            {
                rightAnswerCounter++;
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
                wrongAnswerCounter++;
                MessageBox.Show("Yanlış");
                radioButton1.Checked = false;
                label2.Text = "Yanlış Sayısı : " + wrongAnswerCounter.ToString();
            }
            else if (radioButton2.Checked && currentAnswer != "B")
            {
                wrongAnswerCounter++;
                MessageBox.Show("Yanlış");
                radioButton2.Checked = false;
                label2.Text = "Yanlış Sayısı : " + wrongAnswerCounter.ToString();
            }
            else if (radioButton3.Checked && currentAnswer != "C")
            {
                wrongAnswerCounter++;
                MessageBox.Show("Yanlış");
                radioButton3.Checked = false;
                label2.Text = "Yanlış Sayısı : " + wrongAnswerCounter.ToString();
            }
            else if (radioButton4.Checked && currentAnswer != "D")
            {
                wrongAnswerCounter++;
                MessageBox.Show("Yanlış");
                radioButton4.Checked = false;
                label2.Text = "Yanlış Sayısı : " + wrongAnswerCounter.ToString();
            }

            ort = rightAnswerCounter - (wrongAnswerCounter / 3);
            label3.Text = "Net Sayısı : " + ort.ToString();




            TempId = cl.randNumber();
            pictureBox2.Image = Image.FromFile("c:\\Resim\\" + TempId.ToString() + ".jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            currentAnswer = cl.getAns(TempId);

        }
    }
}

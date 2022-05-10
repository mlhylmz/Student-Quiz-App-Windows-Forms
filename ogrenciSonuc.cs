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
    public partial class ogrenciSonuc : Form
    {
        

        public ogrenciSonuc()
        {
            InitializeComponent();
        }

        public void ogrenciSonuc_Load(object sender, EventArgs e)
        {
            Class1 cl = new Class1();
            int toplamSoru = cl.gettoplamC();
            int net = 3;
            toplamSoruLabel.Text = "Toplam Soru Sayısı : " + toplamSoru;
            DogruLabel.Text = "Doğru Sayısı : " + cl.getrightC().ToString();
            yanlisLabel.Text = "Yanlış Sayısı : " + cl.getwrongC().ToString();
            bosSayiLabel.Text = "Boş Sayısı : " + cl.getemptyC().ToString();
            netSayiLabel.Text = "Net Sayısı : " + net;
        }
    }
}

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

        private void ogrenciSonuc_Load(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            int toplamSoru = ad.getToplam();
            int net = 3;
            toplamSoruLabel.Text = "Topmlam Soru Sayısı : " + toplamSoru;
            DogruLabel.Text = "Doğru Sayısı : " + ad.getRight().ToString();
            yanlisLabel.Text = "Yanlış Sayısı : " + ad.getWrong().ToString();
            bosSayiLabel.Text = "Boş Sayısı : " + ad.getEmpty().ToString();
            netSayiLabel.Text = "Net Sayısı : " + net;
        }
    }
}

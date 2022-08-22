using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogrı.Text = dogru.ToString();
                pictureBox1.Visible = true;


            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogrı.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogrı.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogrı.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            LblSoruno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edildi?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
                
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi şehir ege bölgesinde yer almaz?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                label4.Text = "Balıkesir";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar habgi yazarımıza aittir?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreyya";
                BtnC.Text = "Atilla İlhan";
                BtnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                //BtnSonraki.Text = "Sonuçlar";

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Simgesi Ca olan elemnet hangisidir?";
                BtnA.Text = "Magnezyum";
                BtnB.Text = "Krom";
                BtnC.Text = "Kalsiyum";
                BtnD.Text = "Bor";
                label4.Text = "Kalsiyum";
               // BtnSonraki.Text = "Sonraki";

            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Hababam Sınıfı kim tarafından yazıldı?";
                BtnA.Text = "Oktay Rıfat";
                BtnB.Text = "Orhan Veli";
                BtnC.Text = "Atilla İlhan";
                BtnD.Text = "Rıfat Ilgaz";
                label4.Text = "Rıfat Ilgaz";
             //   BtnSonraki.Text = "Sonuçlar";

            }

            if (soruno == 6)
            {
                richTextBox1.Text = "Süper Lig`de 2020-2021 sezonu şampiyonu hangi takımdır?";
                BtnA.Text = "Beşiktaş";
                BtnB.Text = "Göztepe";
                BtnC.Text = "Galatasaray";
                BtnD.Text = "Başakşehir";
                label4.Text = "Beşiktaş";
                //BtnSonraki.Text = "Sonuçlar";

            }
            if (soruno == 7)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                if (dogru == 6)
                {
                     MessageBox.Show("Dogru: " + dogru + "\n"+ "Yanlis:" + yanlis +"\n" + "Tebrikler!! 60p");
                }
                if (dogru == 5)
                {
                    MessageBox.Show("Dogru: " + dogru + "\n" + "Yanlis:" + yanlis + "\n" + "50p");
                }
                if (dogru == 4)
                {
                    MessageBox.Show("Dogru: " + dogru + "\n" + "Yanlis:" + yanlis + "\n" + "40p");
                }
                if (dogru == 3)
                {
                    MessageBox.Show("Dogru: " + dogru + "\n" + "Yanlis:" + yanlis + "\n" + "30p");
                }
                if (dogru == 2)
                {
                    MessageBox.Show("Dogru: " + dogru + "\n" + "Yanlis:" + yanlis + "\n" + "20p");
                }
                if (dogru == 1)
                {
                    MessageBox.Show("Dogru: " + dogru + "\n" + "Yanlis:" + yanlis + "\n" + "10p");
                }
                if (dogru == 0)
                {
                    MessageBox.Show("Dogru: " + dogru + "\n" + "Yanlis:" + yanlis + "\n" + "Maalesef hiç doğru cevabınız yok!! ÇAlışıp tekrar deneyin!!");
                }


            }
        }
    }
}

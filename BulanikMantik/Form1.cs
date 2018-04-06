using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BulanikMantik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            uzmanverileri();
            datagrid();
            grafik();
        }
        List<List<string>> Tumkurallar = new List<List<string>>();
        List<List<string>> kurallar = new List<List<string>>();
        List<double> uygunlukdegerleri = new List<double>();
        List<double> sonuclar = new List<double>();
        private void button1_Click(object sender, EventArgs e)
        {
        }

        public void uzmanverileri()
        {
            kuraltablosu kuraltablosunagit = new kuraltablosu(11, 11, 11);
            Tumkurallar = kuraltablosunagit.uzmankurallari();
        }

        public void hesapla()
        {
            for (int i = 0; i < 27; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }

            List<double> sonuclar = new List<double>();
            double hassaslik = Convert.ToDouble(numericUpDown1.Value),
                  miktar = Convert.ToDouble(numericUpDown2.Value),
                  kirlilik = Convert.ToDouble(numericUpDown3.Value);

            kuraltablosu kuraltablosunagit = new kuraltablosu(hassaslik, miktar, kirlilik);
            kurallar = kuraltablosunagit.uzmankurallari();

            datagridSec();

            uygunlukhesabi uygunluk = new uygunlukhesabi(hassaslik, miktar, kirlilik, kurallar);
            uygunlukdegerleri = uygunluk.uygunlukhesap();

            listBox1.Items.Clear();
            foreach (var item in uygunlukdegerleri)
            {
                listBox1.Items.Add(item);
            }


            mandani mandanisonuc = new mandani(kurallar, uygunlukdegerleri);
            sonuclar = mandanisonuc.mandaniMaxMin();


            donuslabel.Text = sonuclar[0].ToString();
            surelabel.Text = sonuclar[1].ToString();
            deterjanlabel.Text = sonuclar[2].ToString();
        }
        public void grafik()
        {
            chart1.Series["Sağlam"].Points.AddXY(0, 1);
            chart1.Series["Sağlam"].Points.AddXY(2, 1);
            chart1.Series["Sağlam"].Points.AddXY(4, 0);
            chart1.Series["Orta"].Points.AddXY(3, 0);
            chart1.Series["Orta"].Points.AddXY(5, 1);
            chart1.Series["Orta"].Points.AddXY(7, 0);
            chart1.Series["Hassas"].Points.AddXY(5.5, 0);
            chart1.Series["Hassas"].Points.AddXY(8, 1);
            chart1.Series["Hassas"].Points.AddXY(10, 1);

            chart2.Series["Küçük"].Points.AddXY(0, 1);
            chart2.Series["Küçük"].Points.AddXY(2, 1);
            chart2.Series["Küçük"].Points.AddXY(4, 0);
            chart2.Series["Orta"].Points.AddXY(3, 0);
            chart2.Series["Orta"].Points.AddXY(5, 1);
            chart2.Series["Orta"].Points.AddXY(7, 0);
            chart2.Series["Büyük"].Points.AddXY(5.5, 0);
            chart2.Series["Büyük"].Points.AddXY(8, 1);
            chart2.Series["Büyük"].Points.AddXY(10, 1);

            chart3.Series["Küçük"].Points.AddXY(0, 1);
            chart3.Series["Küçük"].Points.AddXY(2, 1);
            chart3.Series["Küçük"].Points.AddXY(4.5, 0);
            chart3.Series["Orta"].Points.AddXY(3, 0);
            chart3.Series["Orta"].Points.AddXY(5, 1);
            chart3.Series["Orta"].Points.AddXY(7, 0);
            chart3.Series["Büyük"].Points.AddXY(5.5, 0);
            chart3.Series["Büyük"].Points.AddXY(8, 1);
            chart3.Series["Büyük"].Points.AddXY(10, 1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            decimal x = trackBar1.Value * 0.1M;
            Hcubuk.Location = new Point(34 + Convert.ToInt16(x * 21.5M), 40);
            numericUpDown1.Value = x;
            hesapla();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            decimal x = trackBar2.Value * 0.1M;
            Mcubuk.Location = new Point(44 + Convert.ToInt16(x * 21.5M), 184);
            numericUpDown2.Value = x;
            hesapla();
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            decimal x = trackBar3.Value * 0.1M;
            Kcubuk.Location = new Point(44 + Convert.ToInt16(x * 21.5M), 333);
            numericUpDown3.Value = x;
            hesapla();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Hcubuk.Location = new Point(44 + Convert.ToInt16(numericUpDown1.Value * 21.5M), 40);
            trackBar1.Value = Convert.ToInt16(numericUpDown1.Value * 10);
            hesapla();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Mcubuk.Location = new Point(44 + Convert.ToInt16(numericUpDown2.Value * 21.5M), 184);
            trackBar2.Value = Convert.ToInt16(numericUpDown2.Value * 10);
            hesapla();
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Kcubuk.Location = new Point(44 + Convert.ToInt16(numericUpDown3.Value * 21.5M), 333);
            trackBar3.Value = Convert.ToInt16(numericUpDown3.Value * 10);
            hesapla();
        }

        public void datagrid()
        {
            int j = 0;
            foreach (var item in Tumkurallar)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[j].Cells[0].Value = j + 1;
                for (int i = 1; i < 7; i++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = item[i - 1];
                }
                j++;
            }

        }

        public void datagridSec()
        {
            foreach (var item in kurallar)
            {
                for (int i = 0; i < 27; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == item[0].ToString() &&
                        dataGridView1.Rows[i].Cells[2].Value.ToString() == item[1].ToString() &&
                        dataGridView1.Rows[i].Cells[3].Value.ToString() == item[2].ToString() &&
                        dataGridView1.Rows[i].Cells[4].Value.ToString() == item[3].ToString() &&
                        dataGridView1.Rows[i].Cells[5].Value.ToString() == item[4].ToString() &&
                        dataGridView1.Rows[i].Cells[6].Value.ToString() == item[5].ToString())
                    {
                        dataGridView1.Rows[i].Selected = true;
                        continue;
                    }
                }
            }


        }





        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


    }
}

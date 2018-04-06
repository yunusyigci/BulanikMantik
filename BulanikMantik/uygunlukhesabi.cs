using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulanikMantik
{
    class uygunlukhesabi
    {
        double hassaslik;
        double miktar;
        double kirlilik;
        List<List<string>> kurallar = new List<List<string>>();
        public uygunlukhesabi(double hassaslik, double miktar, double kirlilik, List<List<string>> kurallar)
        {
            this.hassaslik = hassaslik;
            this.miktar = miktar;
            this.kirlilik = kirlilik;
            this.kurallar = kurallar;
        }

        List<double> uygunlukdegerleri = new List<double>();


        List<double> uygunluk;
        public List<double> uygunlukhesap()
        {
            double durum = 0;
            foreach (var item in kurallar)
            {
                uygunluk = new List<double>();
                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                        durum = hassaslik;
                    else if (i == 1)
                        durum = miktar;
                    else
                        durum = kirlilik;

                    if (item[i] == "hassas" || item[i] == "buyuk")
                    {
                        double a = buyuk(durum);
                        uygunluk.Add(a);
                        continue;
                    }
                    if (item[i] == "orta")
                    {
                        double b = orta(durum);
                        uygunluk.Add(b);
                        continue;
                    }
                    if (item[i] == "saglam" || item[i] == "kucuk")
                    {
                        double x = 4;
                        if (i == 2)
                            x = 4.5;
                        double c = kucuk(durum, x);
                        uygunluk.Add(c);
                        continue;
                    }
                }
                uygunlukdegerleri.Add(uygunluk.Min());
            }
            return uygunlukdegerleri;
        }


        public double buyuk(double durum)
        {
            if (durum == 5.5)
                return 0;

            if (durum == 8)
                return 1;

            if (durum > 5.5 && durum < 8)
                return (durum - 5.5) / 2.5;

            if (durum > 8)
                return 1;
            return 0;
        }
        public double orta(double durum)
        {
            if (durum == 5)
                return 1;

            if (durum == 7 || durum == 3)
                return 0;

            if (durum > 5 && durum < 7)
                return (durum - 5) / 2;

            if (durum > 3 && durum < 5)
                return (durum - 3) / 2;
            return 0;
        }
        public double kucuk(double durum, double x)
        {
            if (durum == x)
                return 0;

            if (durum <= 2)
                return 1;

            if (durum > 2 && durum < x)
                return (durum - x) / (x - 2) * (-1);
            return 0;
        }

    }
}

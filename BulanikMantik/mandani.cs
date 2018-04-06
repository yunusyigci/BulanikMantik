using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulanikMantik
{

    class mandani
    {

        List<List<string>> kurallar = new List<List<string>>();
        List<double> uygunlukdegerleri = new List<double>();
        public mandani(List<List<string>> kurallar, List<double> uygunlukdegerleri)
        {
            this.kurallar = kurallar;
            this.uygunlukdegerleri = uygunlukdegerleri;
        }



        List<double> donushizi = new List<double>();
        List<double> sure = new List<double>();
        List<double> deterjanmiktari = new List<double>();

        List<double> donushiziort = new List<double>();
        List<double> sureort = new List<double>();
        List<double> deterjanmiktariort = new List<double>();

        List<double> sonuclar = new List<double>();

        public List<double> mandaniMaxMin()
        {
            int i = 0;
            double a = 10000, b = 10000, c = 10000, d = 10000, e = 10000;
            for (int j = 3; j < 6; j++)
            {
                i = 0;
                foreach (var item in kurallar)
                {

                    if (item[j] == "hassas" || item[j] == "kisa" || item[j] == "cok_az")
                    {
                        if (a == 10000)
                        {
                            a = uygunlukdegerleri[i];
                        }
                        else if (a < uygunlukdegerleri[i])
                        {
                            a = uygunlukdegerleri[i];
                        }
                    }
                    if (item[j] == "normal_hassas" || item[j] == "normal_kisa" || item[j] == "az")
                    {
                        if (b == 10000)
                        {
                            b = uygunlukdegerleri[i];
                        }
                        else if (b < uygunlukdegerleri[i])
                        {
                            b = uygunlukdegerleri[i];
                        }
                    }
                    if (item[j] == "orta")
                    {
                        if (c == 10000)
                        {
                            c = uygunlukdegerleri[i];
                        }
                        else if (c < uygunlukdegerleri[i])
                        {
                            c = uygunlukdegerleri[i];
                        }
                    }
                    if (item[j] == "normal_guclu" || item[j] == "normal_uzun" || item[j] == "fazla")
                    {
                        if (d == 10000)
                        {
                            d = uygunlukdegerleri[i];
                        }
                        else if (d < uygunlukdegerleri[i])
                        {
                            d = uygunlukdegerleri[i];
                        }
                    }
                    if (item[j] == "guclu" || item[j] == "uzun" || item[j] == "cok_fazla")
                    {
                        if (e == 10000)
                        {
                            e = uygunlukdegerleri[i];
                        }
                        else if (e < uygunlukdegerleri[i])
                        {
                            e = uygunlukdegerleri[i];
                        }
                    }
                    i++;
                }
                if (j == 3)
                {
                    if (a != 10000) { donushizi.Add(a); donushiziort.Add(0.5); }
                    if (b != 10000) { donushizi.Add(b); donushiziort.Add(2.75); }
                    if (c != 10000) { donushizi.Add(c); donushiziort.Add(5); }
                    if (d != 10000) { donushizi.Add(d); donushiziort.Add(7.25); }
                    if (e != 10000) { donushizi.Add(e); donushiziort.Add(9.5); }
                }
                if (j == 4)
                {
                    if (a != 10000) { sure.Add(a); sureort.Add(22.3); }
                    if (b != 10000) { sure.Add(b); sureort.Add(40); }
                    if (c != 10000) { sure.Add(c); sureort.Add(60); }
                    if (d != 10000) { sure.Add(d); sureort.Add(75); }
                    if (e != 10000) { sure.Add(e); sureort.Add(92.7); }
                }
                if (j == 5)
                {
                    if (a != 10000) { deterjanmiktari.Add(a); deterjanmiktariort.Add(20); }
                    if (b != 10000) { deterjanmiktari.Add(b); deterjanmiktariort.Add(85); }
                    if (c != 10000) { deterjanmiktari.Add(c); deterjanmiktariort.Add(150); }
                    if (d != 10000) { deterjanmiktari.Add(d); deterjanmiktariort.Add(215); }
                    if (e != 10000) { deterjanmiktari.Add(e); deterjanmiktariort.Add(280); }

                }
                a = 10000; b = 10000; c = 10000; d = 10000; e = 10000;
            }

            donushiziagirlikliort();
            sureagirlikliort();
            deterjanmiktariagirlikliort();
            return sonuclar;
        }
        double sonuc1;
        double sonuc2;
        double sonuc3;
        public void donushiziagirlikliort()
        {
            double pay = 0;
            double payda = 0;
            for (int i = 0; i < donushizi.Count; i++)
            {
                pay += donushizi[i] * donushiziort[i];
                payda += donushizi[i];
            }
            sonuc1 = pay / payda;
            sonuclar.Add(sonuc1);
        }
        public void sureagirlikliort()
        {
            double pay = 0;
            double payda = 0;
            for (int i = 0; i < sure.Count; i++)
            {
                pay += sure[i] * sureort[i];
                payda += sure[i];
            }
            sonuc2 = pay / payda;
            sonuclar.Add(sonuc2);
        }
        public void deterjanmiktariagirlikliort()
        {
            double pay = 0;
            double payda = 0;
            for (int i = 0; i < deterjanmiktari.Count; i++)
            {
                pay += deterjanmiktari[i] * deterjanmiktariort[i];
                payda += deterjanmiktari[i];
            }
            sonuc3 = pay / payda;
            sonuclar.Add(sonuc3);
        }

    }
}

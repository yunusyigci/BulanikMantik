using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulanikMantik
{
    class kuraltablosu
    {

        double hassaslik, miktar, kirlilik;
        List<string> kural;
        List<List<string>> kurallar = new List<List<string>>();
        List<List<string>> Tumkurallar = new List<List<string>>();

        public kuraltablosu(double hassaslik, double miktar, double kirlilik)
        {
            this.hassaslik = hassaslik;
            this.miktar = miktar;
            this.kirlilik = kirlilik;
        }

        public List<List<string>> uzmankurallari()
        {
            if ((5.5 <= hassaslik && hassaslik <= 10 && 0 <= miktar && miktar <= 4 && 0 <= kirlilik && kirlilik <= 4.5) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("hassas"); kural.Add("kucuk"); kural.Add("kucuk");
                kural.Add("hassas"); kural.Add("kisa"); kural.Add("cok_az");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((5.5 <= hassaslik && hassaslik <= 10 && 0 <= miktar && miktar <= 4 && 3 <= kirlilik && kirlilik <= 7) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("hassas"); kural.Add("kucuk"); kural.Add("orta");
                kural.Add("normal_hassas"); kural.Add("kisa"); kural.Add("az");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((5.5 <= hassaslik && hassaslik <= 10 && 0 <= miktar && miktar <= 4 && 5.5 <= kirlilik && kirlilik <= 10) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("hassas"); kural.Add("kucuk"); kural.Add("buyuk");
                kural.Add("orta"); kural.Add("normal_kisa"); kural.Add("orta");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((5.5 <= hassaslik && hassaslik <= 10 && 3 <= miktar && miktar <= 7 && 0 <= kirlilik && kirlilik <= 4.5) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("hassas"); kural.Add("orta"); kural.Add("kucuk");
                kural.Add("hassas"); kural.Add("kisa"); kural.Add("orta");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((5.5 <= hassaslik && hassaslik <= 10 && 3 <= miktar && miktar <= 7 && 3 <= kirlilik && kirlilik <= 7) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("hassas"); kural.Add("orta"); kural.Add("orta");
                kural.Add("normal_hassas"); kural.Add("normal_kisa"); kural.Add("orta");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((5.5 <= hassaslik && hassaslik <= 10 && 3 <= miktar && miktar <= 7 && 5.5 <= kirlilik && kirlilik <= 10) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("hassas"); kural.Add("orta"); kural.Add("buyuk");
                kural.Add("orta"); kural.Add("orta"); kural.Add("buyuk");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((5.5 <= hassaslik && hassaslik <= 10 && 5.5 <= miktar && miktar <= 10 && 0 <= kirlilik && kirlilik <= 4.5) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("hassas"); kural.Add("buyuk"); kural.Add("kucuk");
                kural.Add("normal_hassas"); kural.Add("normal_kisa"); kural.Add("orta");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((5.5 <= hassaslik && hassaslik <= 10 && 5.5 <= miktar && miktar <= 10 && 3 <= kirlilik && kirlilik <= 7) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("hassas"); kural.Add("buyuk"); kural.Add("orta");
                kural.Add("normal_hassas"); kural.Add("orta"); kural.Add("fazla");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((5.5 <= hassaslik && hassaslik <= 10 && 5.5 <= miktar && miktar <= 10 && 5.5 <= kirlilik && kirlilik <= 10) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("hassas"); kural.Add("buyuk"); kural.Add("buyuk");
                kural.Add("orta"); kural.Add("normal_uzun"); kural.Add("fazla");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((3 <= hassaslik && hassaslik <= 7 && 0 <= miktar && miktar <= 4 && 0 <= kirlilik && kirlilik <= 4.5) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("orta"); kural.Add("kucuk"); kural.Add("kucuk");
                kural.Add("normal_hassas"); kural.Add("normal_kisa"); kural.Add("az");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((3 <= hassaslik && hassaslik <= 7 && 0 <= miktar && miktar <= 4 && 3 <= kirlilik && kirlilik <= 7) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("orta"); kural.Add("kucuk"); kural.Add("orta");
                kural.Add("orta"); kural.Add("kisa"); kural.Add("orta");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((3 <= hassaslik && hassaslik <= 7 && 0 <= miktar && miktar <= 4 && 5.5 <= kirlilik && kirlilik <= 10) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("orta"); kural.Add("kucuk"); kural.Add("buyuk");
                kural.Add("normal_guclu"); kural.Add("orta"); kural.Add("fazla");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((3 <= hassaslik && hassaslik <= 7 && 3 <= miktar && miktar <= 7 && 0 <= kirlilik && kirlilik <= 4.5) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("orta"); kural.Add("orta"); kural.Add("kucuk");
                kural.Add("normal_hassas"); kural.Add("normal_kisa"); kural.Add("orta");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((3 <= hassaslik && hassaslik <= 7 && 3 <= miktar && miktar <= 7 && 3 <= kirlilik && kirlilik <= 7) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("orta"); kural.Add("orta"); kural.Add("orta");
                kural.Add("orta"); kural.Add("orta"); kural.Add("orta");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((3 <= hassaslik && hassaslik <= 7 && 3 <= miktar && miktar <= 7 && 5.5 <= kirlilik && kirlilik <= 10) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("orta"); kural.Add("orta"); kural.Add("buyuk");
                kural.Add("hassas"); kural.Add("uzun"); kural.Add("fazla");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((3 <= hassaslik && hassaslik <= 7 && 5.5 <= miktar && miktar <= 10 && 0 <= kirlilik && kirlilik <= 4.5) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("orta"); kural.Add("buyuk"); kural.Add("kucuk");
                kural.Add("hassas"); kural.Add("orta"); kural.Add("orta");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((3 <= hassaslik && hassaslik <= 7 && 5.5 <= miktar && miktar <= 10 && 3 <= kirlilik && kirlilik <= 7) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("orta"); kural.Add("buyuk"); kural.Add("orta");
                kural.Add("hassas"); kural.Add("normal_uzun"); kural.Add("fazla");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((3 <= hassaslik && hassaslik <= 7 && 5.5 <= miktar && miktar <= 10 && 5.5 <= kirlilik && kirlilik <= 10) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("orta"); kural.Add("buyuk"); kural.Add("buyuk");
                kural.Add("hassas"); kural.Add("uzun"); kural.Add("cok_fazla");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((0 <= hassaslik && hassaslik <= 4 && 0 <= miktar && miktar <= 4 && 0 <= kirlilik && kirlilik <= 4.5) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("saglam"); kural.Add("kucuk"); kural.Add("kucuk");
                kural.Add("orta"); kural.Add("orta"); kural.Add("az");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((0 <= hassaslik && hassaslik <= 4 && 0 <= miktar && miktar <= 4 && 3 <= kirlilik && kirlilik <= 7) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("saglam"); kural.Add("kucuk"); kural.Add("orta");
                kural.Add("normal_guclu"); kural.Add("orta"); kural.Add("orta");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((0 <= hassaslik && hassaslik <= 4 && 0 <= miktar && miktar <= 4 && 5.5 <= kirlilik && kirlilik <= 10) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("saglam"); kural.Add("kucuk"); kural.Add("buyuk");
                kural.Add("guclu"); kural.Add("normal_uzun"); kural.Add("fazla");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((0 <= hassaslik && hassaslik <= 4 && 3 <= miktar && miktar <= 7 && 0 <= kirlilik && kirlilik <= 4.5) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("saglam"); kural.Add("orta"); kural.Add("kucuk");
                kural.Add("orta"); kural.Add("orta"); kural.Add("orta");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((0 <= hassaslik && hassaslik <= 4 && 3 <= miktar && miktar <= 7 && 3 <= kirlilik && kirlilik <= 7) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("saglam"); kural.Add("orta"); kural.Add("orta");
                kural.Add("normal_guclu"); kural.Add("normal_uzun"); kural.Add("orta");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((0 <= hassaslik && hassaslik <= 4 && 3 <= miktar && miktar <= 7 && 5.5 <= kirlilik && kirlilik <= 10) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("saglam"); kural.Add("orta"); kural.Add("buyuk");
                kural.Add("guclu"); kural.Add("orta"); kural.Add("cok_fazla");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((0 <= hassaslik && hassaslik <= 4 && 0 <= miktar && miktar <= 4 && 3 <= kirlilik && kirlilik <= 7) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("saglam"); kural.Add("kucuk"); kural.Add("orta");
                kural.Add("saglam"); kural.Add("buyuk"); kural.Add("kucuk");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((0 <= hassaslik && hassaslik <= 4 && 5.5 <= miktar && miktar <= 10 && 3 <= kirlilik && kirlilik <= 7) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("saglam"); kural.Add("buyuk"); kural.Add("orta");
                kural.Add("normal_guclu"); kural.Add("uzun"); kural.Add("fazla");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);
            if ((0 <= hassaslik && hassaslik <= 4 && 5.5 <= miktar && miktar <= 10 && 5.5 <= kirlilik && kirlilik <= 10) || 11 == hassaslik)
            {
                kural = new List<string>();
                kural.Add("saglam"); kural.Add("buyuk"); kural.Add("buyuk");
                kural.Add("guclu"); kural.Add("uzun"); kural.Add("cok_fazla");
                kurallar.Add(kural);
            }
            Tumkurallar.Add(kural);

            if (hassaslik == 11 && miktar == 11 && kirlilik == 11)
                return Tumkurallar;
            return kurallar;
        }
    }
}
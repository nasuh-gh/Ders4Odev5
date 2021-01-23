using System;

namespace Ders4Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string> takimlar = new MyDictionary<string,string>();

            takimlar.Add("Sarı-Kırmızı","Galatasaray");
            takimlar.Add("Sarı-Lacivert","Fenerbahçe");
            takimlar.Add("Siyah-Beyaz", "Beşiktaş");

        }
    }
}

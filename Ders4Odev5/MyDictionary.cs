using System;
using System.Collections.Generic;
using System.Text;

namespace Ders4Odev5
{
    class MyDictionary<R, T>
    {
        R[] renkler;
        T[] items;
        public MyDictionary()//Constructor-Class'ı new'lersen burası çalışıyor
        {
            renkler = new R[0];
            items = new T[0];
        }

        public void Add(R renk, T item)
        {
            R[] tempRenk = renkler;
            T[] tempArray = items;//geçici olarak referans numarasını burada tutturuyoruz
            renkler = new R[renkler.Length + 1];
            items = new T[items.Length + 1];//yukarıdakini yapmasaydık önceki verilerim kaybolacaktı
            for (int i = 0; i < tempArray.Length; i++)//geçici emanet olarak verdiğim elemanları geri alacağım
            {
                renkler[i] = tempRenk[i];
                items[i] = tempArray[i];
            }
            renkler[renkler.Length - 1] = renk;
            items[items.Length - 1] = item;//burada add'le gelen yeni elemanı boş kısma ekliyoruz(getiriyoruz)
            //length -1 toplam eleman sayısından 1 eksik yani index değeri

            Console.WriteLine("Renk: "+renk + " Takım: " + item);

        }
    }
}

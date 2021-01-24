using System;
using System.Collections.Generic;
using System.Text;

namespace Odev4
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] tkey;
        TValue[] tvalue;

        public MyDictionary()
        {
            tkey = new TKey[0];
            tvalue = new TValue[0];
        }

        public void Ekle(TKey itemKey, TValue itemValue)
        {
            int count = 0;
            //Eğer itemKey daha önceden eklenmiş ise sayacı bir artırıyoruz.
            for (int i = 0; i < tkey.Length; i++)
            {
                if (itemKey.Equals(tkey[i]))
                {
                    count++;
                    break;
                }

            }
            //Eğer sayac 0 ise itemKey daha önce eklenmemiştir.
            if (count == 0)
            {
                TKey[] tempTKey = tkey;
                TValue[] tempTValue = tvalue;

                tkey = new TKey[tkey.Length + 1];
                tvalue = new TValue[tvalue.Length + 1];

                for (int i = 0; i < tempTKey.Length; i++)
                {
                    tkey[i] = tempTKey[i];
                    tvalue[i] = tempTValue[i];
                }

                tkey[tkey.Length - 1] = itemKey;
                tvalue[tkey.Length - 1] = itemValue;
            }
            //Eğer sayac 0 değil ise itemKey daha önce eklenmiştir.
            else
            {
                Console.WriteLine("Bu itemKey zaten kullanılıyor.");
            }
            

        }
        //Tümünü listeler.
        public void Listele()
        {
            for (int i = 0; i < tkey.Length; i++)
            {
                Console.WriteLine("Öğrenci Numarası : "+tkey[i]+" Adı Soyadı : "+tvalue[i]);
            }
        }
        //Gönderilen itemKey eğer listede varsa onu listeler.
        public void Listele(TKey itemKey)
        {
            int count = 0;
            for (int i = 0; i < tkey.Length; i++)
            {
                if (itemKey.Equals(tkey[i]))
                {
                    Console.WriteLine("Öğrenci Numarası : " + tkey[i] + " Adı Soyadı : " + tvalue[i]);
                    count++;
                }
            }

            if (count.Equals(0))
            {
                Console.WriteLine("Kayıt Bulunamadı :"+count);
            }
        }


    }
}

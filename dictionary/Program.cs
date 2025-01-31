﻿using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collection.generic
            Dictionary<int,string> kullanicilar= new Dictionary<int, string>(); 
            kullanicilar.Add(10,"Ayşe Yilmaz");
            kullanicilar.Add(12,"Ahmet Yilmaz");
            kullanicilar.Add(18,"Deniz Arda");
            kullanicilar.Add(20,"Özcan Coşar");

            //Dizinin Elemanlarına Erişim
            Console.WriteLine("**** Elemanlara Erişim");
            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Count

            Console.WriteLine("**** Count ****");
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine("**** Contains ****");

            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Zikriye Ürkmez"));

            //Remove

            Console.WriteLine("**** Remove ****");
            kullanicilar.Remove(12);
            
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Keys
            Console.WriteLine("**** Keys ****");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }
            //Values
            Console.WriteLine("**** Values ****");
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
}

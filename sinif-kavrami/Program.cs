﻿using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Söz Dizimi
            class SinifAdi
            {
                [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
                [Erişim Belirleyici] [Geri Dönüş Tipi] Metotadi([Parametre Listesi])
                {
                    Metot Komutları
                }
            }
            */

            //Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected

            Calisan calisan1=new Calisan();
            calisan1.Ad="Ayşe";
            calisan1.Soyad="Kara";
            calisan1.No=23425634;
            calisan1.Departman="İnsan Kaynakları";

            calisan1.CalisanBilgileri();

            Console.WriteLine("*********");

            Calisan calisan2 = new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=25646789;
            calisan2.Departman="Satın Alma";

            calisan2.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;

        public int No;

        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Adı:{0}",Soyad);
            Console.WriteLine("Çalışan Numarası:{0}",No);
            Console.WriteLine("Çalışan Departmanı:{0}",Departman);


            
        }

    }
}
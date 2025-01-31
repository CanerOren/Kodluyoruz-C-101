﻿using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş Olduğunuz Sayı Şudur:" + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata " + ex.Message.ToString());
            }
            finally
            {
                Console.Write("İşlem tamamlandı");
            }*/
            try
            {
                // int a=int.Parse(null);
                // int a = int.Parse("test");
                int a =int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }       
            catch(FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun Değil.");
                Console.WriteLine(ex);
            }   
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok Küçük ya da Çok Büyük Bir Değer Girdiniz.");
                Console.WriteLine(ex);  
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
                 
            }
        }
    }
}
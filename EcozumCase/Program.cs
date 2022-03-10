using System;

namespace EcozumCase
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                try
                {
                    Console.WriteLine("Bir Sayi Giriniz.");
                    Console.WriteLine(yaziyaCevir(Convert.ToInt32(Console.ReadLine())));
                    break;
                }
                catch
                {

                    Console.WriteLine("Lütfen tam sayı giriniz.");
                    continue;
                } 
            }
                             
        }
        public static string yaziyaCevir(int sayi)
        {
            string tamSayi = sayi.ToString();
            

            
            string yazi = "";

            string[] birler = { "", "BİR ", "İKİ ", "ÜÇ ", "DÖRT ", "BEŞ ", "ALTI ", "YEDİ ", "SEKİZ ", "DOKUZ " };
            string[] onlar = { "", "ON ", "YİRMİ ", "OTUZ ", "KIRK ", "ELLİ ", "ALTMIŞ ", "YETMİŞ ", "SEKSEN ", "DOKSAN " };
            string[] binler = { "KATRİLYON ", "TRİLYON ", "MİLYAR ", "MİLYON ", "BİN ", "" };
               

            int grupSayisi = 6;
               

            tamSayi = tamSayi.PadLeft(grupSayisi * 3, '0');
               

            string grupDegeri;
            for (int i = 0; i < grupSayisi * 3; i += 3) 
            {
                grupDegeri = "";
                string s = tamSayi.Substring(i, 1);
                if (s != "0")
                    grupDegeri += birler[Convert.ToInt32(tamSayi.Substring(i, 1))] + "YÜZ";           
                if (grupDegeri == "BİRYÜZ")      
                    grupDegeri = "YÜZ";
                grupDegeri += onlar[Convert.ToInt32(tamSayi.Substring(i + 1, 1))];  
                grupDegeri += birler[Convert.ToInt32(tamSayi.Substring(i + 2, 1))];    
                if (grupDegeri != "")   
                    grupDegeri += binler[i / 3];
                if (grupDegeri == "BİRBİN")       
                    grupDegeri = "BİN";
                yazi += grupDegeri;
            }

            

            yazi = yazi.Replace("YÜZ", "YÜZ ").Replace("BİN", "BİN ");
            return yazi;
        }
    }
}

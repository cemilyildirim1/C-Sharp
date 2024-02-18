using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {


    class steven
        {
            public void soru2(){
                Console.WriteLine("10 ile 99 arasında bir sayı giriniz.");
                var sayi =Convert.ToInt32(Console.ReadLine());
                var sayi1 = sayi % 10;
                var sayi2 = sayi / 10;
                var sayi3 = sayi1 + sayi2;

                if (sayi3 %2 == 0 && sayi %2 == 0)
                {
                    Console.WriteLine("çift ve steven");
                }
                if(sayi3 %2 == 0 && (sayi %2 != 0 ))
                {
                   Console.WriteLine("tek ve steven");
                }
                if (sayi3 %2 != 0 && sayi % 2 == 0){
                    Console.WriteLine("çift ve steven değil");
                }
                if (sayi3 % 2 != 0 && sayi % 2 != 0)
                {
                    Console.WriteLine("tek ve steven değil");
                }



            }
    


        }
        class Mukemmel

        {

            public void soru3()
            {
                Console.WriteLine("1 ila 9 arasında bir sayu giriniz.");
                var sayi = Convert.ToInt32(Console.ReadLine());

                switch (sayi)
                {
                    case 1:
                    case 4:
                    case 9:
                        Console.WriteLine("Mükemmel kare");
                        break;
                    case 2:
                    case 6:
                    case 8:
                        Console.WriteLine("Çift sayı");
                        break;
                    case 3:
                    case 5:
                    case 7:
                        Console.WriteLine("Asal sayı");
                        break;
                }
            }
        }
        class madde
        {
            public void soru4()
            {
                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine(i);
                    for(int j = 1; j < 6; j++)
                    {
                        Console.WriteLine(i +"."+j);
                        for(int k = 1; k < 5;k++)
                        {
                            Console.WriteLine(i+"."+j+"."+k);
                        }
                    }
                }
            }

        }
        class dizi
        {
            public void soru5()
            {
                char[] arr1 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
                char[] arr2 = { 'b', 'e', 'g','d'};
                bool kontrol = true;
                
                foreach(char x in arr2)
                {
                    
                        foreach (char y in arr1)
                        {

                            if (x == y)
                            {
                                kontrol = true;
                                break;
                            }
                            else
                            {
                                kontrol = false;

                            }
                        
                        }
                    }
                
                if(kontrol)
                {
                    Console.WriteLine("arr2 dizisi arr1'nin alt dizisidir.");
                }
                else
                {
                    Console.WriteLine("ALT DİZİ DEĞİLDİR");
                }







            }
        }
        abstract class GeometrikSekil
        {
            public abstract void AlanHesapla();
            
        }
        class Dikdortgen : GeometrikSekil
        {
            public override void AlanHesapla()
            {
                var kısaKenar = Convert.ToInt32(Console.ReadLine());
                var uzunKenar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Alan : " + kısaKenar*uzunKenar);


            }
        }
        class Daire : GeometrikSekil
        {
            public override void AlanHesapla()
            {
                var yarıCap = Convert.ToInt32(Console.ReadLine());
                var pi = 3;

                Console.WriteLine("Alan : " + (yarıCap*yarıCap) * pi);


            }
        }

        static void Main(string[] args)
        {
            ///*
            //Mukemmel m = new Mukemmel();
            //m.soru3();*/

            /*Random random = new Random();
            for(int i =0 ; i < 6; i++) {
                int x = random.Next(1, 50);
                Console.WriteLine("Sayi"+(i+1) + ":" + x);

            }*/

            //steven steven = new steven();
            //steven.soru2();


            //madde mad = new madde();
            //mad.soru4();


            dizi d = new dizi();
            d.soru5();

            //Daire daire = new Daire();
            //daire.AlanHesapla();

            //Dikdortgen dikdortgen = new Dikdortgen();
            //dikdortgen.AlanHesapla();

            Console.ReadLine(); 









        }
    }
}

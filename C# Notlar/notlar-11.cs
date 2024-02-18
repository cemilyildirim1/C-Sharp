//MATH

// double sonuc;

// sonuc = Math.Pow(2,5);
// sonuc = Math.Sqrt(25);
// sonuc = Math.Abs(-20);
// sonuc = Math.Round(4.6);
// sonuc = Math.Ceiling(4.1);  //5
// sonuc = Math.Floor(4.9);    //4
// sonuc = Math.Max(20,30);
// sonuc = Math.Min(10,30);
// Console.WriteLine(sonuc);

// int a = 5 , b = 5 ;

// var sonuc = a > b ? "a büyük" : (a == b) ? "a b ye eşit" :" b büyük";
// var sonuc2 = (a == 4) || (b == 4);
// Console.WriteLine(!sonuc2);


// UYGULAMA

// using System.Diagnostics;

// Console.WriteLine("Yaşınızı giriniz : ");

// var yas = Convert.ToInt64(Console.ReadLine());
// Console.WriteLine("Ailesinin izli varmı var ise 1 giriniz yok ise 0  giriniz : ");

// var izin = Convert.ToInt64(Console.ReadLine());

// Console.WriteLine(yas >= 18 || izin ==1 ? "Kişi ÇALIŞABİLİR" : "çalışamaz");

// using System.Reflection;

// Console.Write("Tahsilinizi giriniz : ");
// var tahsil = Console.ReadLine();
// Console.Write("Sigara giriniz : ");
// bool sigara = Convert.ToBoolean(Console.ReadLine());
// Console.WriteLine(  (tahsil == "onlisans" || tahsil == "lisans") &&  (sigara == false) ? "İŞE GİREBİLİR" : "işe giremez");

// NOTLAR -12

// Random rnd = new Random();

// String[] takimlar = {"Beşiktaş" , "Galatasaray" , "Fenerbahçe" , "Trabozn"};

// int sayi = rnd.Next(0,4);

// Console.WriteLine(takimlar[sayi]);


// NOtLAR -13

// Console.WriteLine("Kaçıncı ayın mevsimini öğrenmek istiyorsunuz ?");
// var sayi = Convert.ToInt32(Console.ReadLine());

// switch (sayi)
// {
//     case 12:
//     case 1 :
//     case 3 :
//         Console.WriteLine("Kış");
//         break;
//     case 5:
//     case 6:
//     case 7:
//         Console.WriteLine("yaz");
//         break;
//     default:
//         Console.WriteLine("yanlış ay bilgisi");
//         break;
// }


// NOTLAR -14


var  sayi = -8;

var sonuc = (sayi %2 == 0) ? 
            (sayi > 0) ? "Sayı pozitif çift sayıdır":"Sayı negatif çift sayıdır.":
            (sayi > 0) ? "Sayı pozitif tek sayıdır.":"Sayı negatif tek sayıdır.";


Console.WriteLine(sonuc);








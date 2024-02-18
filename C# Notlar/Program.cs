//NOTLAR -1
// var sayi1 = Convert.ToInt64(Console.ReadLine());
// Console.WriteLine("Alınan sayi 1 : " + sayi1);

// var sayi2 = Convert.ToInt64(Console.ReadLine());
// Console.WriteLine("Alınan sayi 2 : " + sayi2);

// var toplam = sayi1 + sayi2;

// Console.WriteLine("Sayılar Toplamı : " + toplam);

// int a = Console.ReadLine();

// Console.WriteLine(a);

// int a = 1;
// byte b=(byte)a;

// double x = 245;
// float z = (float)x;

// float sayi = 245.5f;
// Console.Write(sayi);

// string deger = a.ToString();


//NOTLAR-2


// int? maas =default;
// bool? isActive = null;

// Console.WriteLine(maas.HasValue);
// Console.WriteLine(maas.GetValueOrDefault());
// Console.WriteLine(isActive.HasValue);



//NOTLAR -3

// Console.Write("adı:");
// var adı = Console.ReadLine();

// Console.Write("soy ad :");
// string soyAd = Console.ReadLine();

// Console.Write("yaş:");
// var yas = Console.ReadLine();

// var deger = $"Adı : {adı} Soyadı : {soyAd} Yaşı: {yas}  ";
// Console.WriteLine(deger);


//NOTLAR-4

// string mesaj = " Cemil Yıldırım 21 yaşındadır.  ";

// var sonuc = mesaj[0];
// var sonuc = mesaj.Length;
// var sonuc = mesaj.ToUpper();
// var sonuc = mesaj.ToLower();
// var sonuc = mesaj.Trim();
// var sonuc = mesaj.Split()[2];
// var sonuc = mesaj.StartsWith("C");
// var sonuc = mesaj.EndsWith(".");
// var sonuc = mesaj.Contains("Yıldırım");
// var sonuc = mesaj.IndexOf("Cemil");
// var sonuc = mesaj.Substring(7,8);

// Console.WriteLine(sonuc);



// Notlar -5

// string kursAdi = ".NET 7 ile C# Programlama Dili";

// var sonuc = kursAdi.Length;
// var sonuc = kursAdi.ToLower();
// var sonuc = kursAdi.StartsWith(".");
// var sonuc = kursAdi.IndexOf("C#");
// var sonuc = kursAdi.Contains("C#");
// var sonuc = kursAdi.Replace("Dili","Dersleri");


// Console.WriteLine(sonuc);



// NOTLAR -6

// var simdi = DateTime.Now;

// Console.WriteLine(simdi);
// Console.WriteLine(simdi.Year);
// Console.WriteLine(simdi.Month);
// Console.WriteLine(simdi.Day);
// Console.WriteLine(simdi.DayOfWeek);
// Console.WriteLine(simdi.Hour);
// Console.WriteLine(simdi.Minute);
// Console.WriteLine(simdi.Second);

// DateTime dt = new DateTime(2022 , 6 , 10 , 14 ,30 ,45);
// DateTime dt2 = dt.AddYears(1);
// DateTime dt3 = dt.AddHours(2);

// var fark = simdi - dt;

// Console.WriteLine(fark);


//NOTLAR -7

// int [] sayilar = new int[3];

// sayilar[0] = 10;
// sayilar[1] = 20;
// sayilar[2] = 30;

// Console.WriteLine(sayilar[0]);

// string [] isimler = new string[3];

// isimler[0] = "Cemil";
// isimler[1] = "Buse";
// isimler[2] = "Emir";

// Console.WriteLine(isimler[2]);

// string [] sehirler = {"istanbul","rize","kocaeli"};


// Console.WriteLine(sehirler.GetValue(1));
// Console.WriteLine(Array.IndexOf(sehirler,"rize"));

// Array.Clear(sehirler);
// Console.WriteLine(sehirler[0]);




// string [] sehirler = {"zonguldak","istanbul","rize","kocaeli","ankara"};

// var sonuc = sehirler[0..3];


// foreach(var x in  sehirler) {
//     Console.WriteLine(x);
// }

// Console.WriteLine(sonuc.Length);
// Console.WriteLine(sonuc[0]);
// Console.WriteLine(sonuc[1]);
// Console.WriteLine(sonuc[2]);

// foreach(var x in sehirler[0..3]) {
//    Console.WriteLine(x);
// }
// foreach(var x in sehirler[3..]) {
//    Console.WriteLine(x);
// }




//  NOTLAR -8 UYGULAMA


// String [] ogrenciler = new string[3];

// int [] notlar = new int[3];

// for(var i =0 ; i < 3 ; i++) {
//     Console.Write("Öğrenci ismi giriniz : ");
//     ogrenciler[i] = Console.ReadLine();

//     Console.Write("Öğrenci notu giriniz : ");
//     notlar[i] = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine($"1. Öğrencinin ismi : {ogrenciler[0]}  öğrencinin notu : {notlar[0]}");
// Console.WriteLine($"2. Öğrencinin ismi : {ogrenciler[1]}  öğrencinin notu : {notlar[1]}");
// Console.WriteLine($"3. Öğrencinin ismi : {ogrenciler[2]}  öğrencinin notu : {notlar[2]}");
// var not_ortalaması = (notlar[0] + notlar[1] + notlar[2] ) / 3;

// Console.WriteLine($"Öğrenciler notlar ortalaması {not_ortalaması}");


// for (var i =0 ; i<2 ; i++){
//     Console.WriteLine($"{i+1} . öğrenci için : isim :{ogrenciler[i]} not: {notlar[i]} \n  ");
// }

// Console.WriteLine($"1 . ve 2 . öğrencilerin isimleri ve notları : isim :{ogrenciler[0]} not: {notlar[0]} \n isim: {ogrenciler[1]} not : {notlar[1]} ");

// Console.WriteLine("Öğrenciler dizisi eleman sayısı : " + ogrenciler.Length);




// NOTLAR  -9


// string [] ogrenciler = {"Ali" , "Ahmet" , "Canan"};

// int [,] notlar = new int[3,3];

// // ali
// notlar[0,0] = 50;
// notlar[0,1] = 60;
// notlar[0,2] = 70;

// // ahmet
// notlar[1,0] = 60;
// notlar[1,1] = 80;
// notlar[1,2] = 90;

// // canan
// notlar[2,0] = 50;
// notlar[2,1] = 70;
// notlar[2,2] = 30;
        
// var ortalama_1 = (notlar[0,0] + notlar[0,1] + notlar[0,2]) /3;
// var ortalama_2 = (notlar[1,0] + notlar[1,1] + notlar[1,2]) /3;
// var ortalama_3 = (notlar[2,0] + notlar[2,1] + notlar[2,2]) /3;

// Console.WriteLine($"{ogrenciler[0]} isimli öğrencinin not ortalaması : {ortalama_1}");
// Console.WriteLine($"{ogrenciler[1]} isimli öğrencinin not ortalaması : {ortalama_2}");
// Console.WriteLine($"{ogrenciler[2]} isimli öğrencinin not ortalaması : {ortalama_3}");







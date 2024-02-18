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

var simdi = DateTime.Now;

// Console.WriteLine(simdi);
// Console.WriteLine(simdi.Year);
// Console.WriteLine(simdi.Month);
// Console.WriteLine(simdi.Day);
// Console.WriteLine(simdi.DayOfWeek);
// Console.WriteLine(simdi.Hour);
// Console.WriteLine(simdi.Minute);
// Console.WriteLine(simdi.Second);

DateTime dt = new DateTime(2022 , 6 , 10 , 14 ,30 ,45);
DateTime dt2 = dt.AddYears(1);
DateTime dt3 = dt.AddHours(2);

var fark = simdi - dt;

Console.WriteLine(fark);


 
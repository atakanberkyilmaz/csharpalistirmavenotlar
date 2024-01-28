#region Notlar
/* todo: tasklistte gözükür 
 * versiyonları bil
 * referans tipli-> heap
 * değer tipli-> stackte tutulur
 * breakpoint(f9 ile konulabilir): f5 ile çalıştırılır o satırda durur, f10'a basarsak çalışır
 * functionın içine girmek için f11
 * local değişken tanımlanırken  default olarak değer atanmaz yani kullanılamaz, globalde atanır
 * runtime derlenmeden önce geçen zaman -> compilertime
 * float değerinin sonuna f eklenir, 20.4f 
 * decimalin sonuna da M eklenir, 20.4M
 * ondalıklı sayıların defaultu double, tamsayı int'tir
 * tuple bir değişken ismiyle birçok değişken tutabilmek amacıyla
 */
#endregion
#region Aritmetik İşlemler
//int toplam = 5 + 9;
//int sayi = 5;
//int sayi2 = 10;
//int sonuc = sayi1 + sayi2;

//int sayi3 = 500;
//double sayi4 = 50.50;

//var ss = sayi3 + sayi4;  //daha kapsamlı hangisiyse ona göre işlem yapar c# 
//int sonuc5 = 5 * 3;
//double sonuc6 = 25 / 3; //int sonuç verir çünkü eşitliğin sağ tarafındakiler int
//var sonuc7 = 25.0 / 5;
//var sonuc8 = 50 - 90;
//var sonuc9 = 50 % 4;

//byte a = 5;
//byte b = 10;
//var sonuc10 = b + a; // !byte ile byte'ı toplamamıza rağmen yine int sonuç verir.

//short a1 = 5;
//short a2 = 10;
//var sonuc11 = b + a;

//int a3 = 60;
//int a4 = 60;
//var sonuc12 = a3 + a4;

//int num = 10;
//num = num + 1;



//char karakter2 = 'A';
//var sonuc19 = karakter + 50; //ascii koduyla 

//Console.WriteLine(num++); //önce 11 gönderilir metota ve sonra değer arttırılır.(önce yazdırır sonra arttırır)
//Console.WriteLine(++num); //önce 12 13 olur sonra 13 değeri parametre olarak gönderilir.

#endregion
#region Akış Kontrolü
using System;
using System.Text;

var etkinligeKatilacakmi = true;

if (etkinligeKatilacakmi)
{
    Console.WriteLine("Katılacak");

}
else
{
    Console.WriteLine("Katılmayacak");
}

//Sayının Tek mi Çift mi olduğunu belirleyen örnek
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi % 2 == 0)
{
    Console.WriteLine("Girdiğiniz Sayı Çift");

}
else
{
    Console.WriteLine("Girdiğiniz Sayı Tek");
}
// Kullanıcdan 2 sayı istenerek 1.sayısın 2.sayıya tam böünmesi durumunda "Tam Bölünüyor" yazan, aksi durumda tam böünmüyor 
//yazan uygulama

//int sayi1, sayi2, kalan;
//Console.WriteLine("1. Sayıyı Girin:");
//sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2.Sayıyı Girin: ");
//sayi2 = Convert.ToInt32(Console.ReadLine());
//kalan = sayi1 % sayi2;
//if(kalan == 0)
//{
//    Console.WriteLine("Tam Bölünüyor");
//}
//else
//{
//    Console.WriteLine("Tam Bölünmüyor");
//}

//int sayi3 = 5;
//int sayi4 = 5;
//if (sayi3 == sayi4)
//{
//    Console.WriteLine("eşit");
//}
#endregion
#region Döngüler
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
for (; ; ) //sonsuz döngü
{

}
for (int i = 0, j = 5; i < 10 && j < 20; i++, j+=5)
{
    Console.WriteLine(i);
    Console.WriteLine(j);
}
int sayici = 0;
while (sayici < 10) // döngünün ne kadar süreceğini bilmiyorsam while kullanırım
{
    Console.WriteLine(sayici);
    sayici++;
}

bool dogruDegerGirildiMi = false;
while (dogruDegerGirildiMi == false)
{
    Console.WriteLine("Bir Sayı Giriniz: ");
    var girilenDeger = Console.ReadLine();
    try
    {
        var deger1 = int.Parse(girilenDeger);
        dogruDegerGirildiMi = true;
        for (int i = 0; i < deger1; i++)
        {
            Console.WriteLine("Isubu");
        }
    }
    catch (Exception)
    {

    }
    while (true) //sonsuz döngü
    {
        var deger2 = Console.ReadLine();

        if (deger2 == "cik")
        {
            break;
        }

    }
    do
    {
        Console.WriteLine("");
    } while (true);
}

for (int i = 0; i < 10; i++)
{
    if(i == 5)
    {
        break;
    }
}

//Girilen 10 sayı içinde pozitif ve tek olan sayıların çarpımını yazdıran For döngüsü ile

int sayi6;
int sonuc = 1;
for (int i= 1; i<=10; i++)
{
    Console.WriteLine("{0}. Sayıyı Giriniz:", i);
    sayi6 = Convert.ToInt32(Console.ReadLine());
    if((sayi6> 0 ) && (sayi %2 ==1))
    {
        sonuc *= sayi6;
        

    }
    Console.WriteLine();
}
Console.WriteLine("Pozitif ve tek sayıların çarpımı : " + sonuc);


//For döngüsü kullanılarak A'dan z'ye kadar olan harfleri ekranda gösteren örnek:
char karakter;
for (karakter = 'a'; karakter <= 'z'; karakter++)
{
    Console.WriteLine("{0}", karakter);
}


//Dikdörtgen oluşturma
int genislik, yukseklik;
Console.WriteLine("Dikdörtgenin genişliğini giriniz:");
genislik = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dikdörtgenin yüksekliğini giriniz:");
yukseklik = Convert.ToInt32(Console.ReadLine());
for ( int i =0; i< yukseklik; i++)
{
    for(int j = 0; j < genislik; j++)
    {
        Console.WriteLine("*");

    }
    Console.WriteLine();
}

#endregion
#region Diziler
int[] sayilar = new int[10];
string[] ogrenciler = new string[5];
bool[] engellilikDurumu = new bool[5];
int[] yaslar = {1,2,3,4,5};

var value = yaslar[2];

for(int i = 0; i< yaslar.Length; i++)
{
    yaslar[i] = default;
}
int[] yaslar3 = new int[yaslar.Length];
Array.Copy(yaslar, yaslar.Length); //orijinal değerin bozulmamasını istemiyorsam bu şekilde kopyalarım

Array.Sort(yaslar); //küçükten büyüğe sıralar
Array.Reverse(yaslar);//terse çevirir
Array.Sort(yaslar); // bu sefer büyükten küçüğe sıralar


#endregion
#region String Operasyonları
string ad1 = "";
string ad2 = string.Empty;
string ad3 = null;
var adiBosveyaNullmi = string.IsNullOrEmpty(ad1);

if(string.IsNullOrEmpty(ad2))
{
    Console.WriteLine("adınızı girmediniz");
}

var name = "Ali";
var tamAd2 = string.Format("{0} {1}", name);

stringBuilder sb = new stringBuilder();//performans açısından en mantıklısıdır string birleştirme işleminde
sb.Append(nam)//console.write gibi
            sb.Append(" ");
sb.Append(snam);
sb.AppendFormat("{0} ile {1} arasında", 20, 60);

var nm = "Mehmet";
var snm = "USUL";
var bakye = 50.5M;
var message = "Sayın " + nm + " " + snm + " hesabınızda " + bakye + " TL vardır.";
var message2 = $"Sayın {ad} {soyad} hesabınızda " + $"({bakye} >0 ? $//bu şekilde yazmamızı sağlar dolar simgesi //turnet
       var msg = "Ne kadar bilirsen bil bir bilene danış";
var snnc = msg.StartsWith("ne");//false döner çünkü case sensetive, ama kapatılır
var snnc2 = msg.EndsWith("ış");//true döner;
var snnc3 = msg.Contains("danış");//true döner

string ad10 = "Ali";
string ad11 = "Ali";
var esitMi = string.Equals(ad10, ad11);
var esitMi2 = ad10 == ad11; //üstteki ile aynı


var msg = "Ne kadar bilirsen bil bir bilene danış";
var indis = msg.IndexOf("dost");//yoksa -1 döndürür
var indis2 = msg.IndexOf("n");

var msg2 = msg.Remove(indis);//16.karakterden sonrasını siler,16. dahil
var msg3 = msg.Remove(2, 3);//2.den başla 3.'ye kadar siler

var msg4 = msg.Replace("dost", "arkadaş");//dost kelimesini arkadaş'a çevirir
var msg5 = msg.Replace(" ", "");//boşlukları değiştirir

var msg9 = "    Ali    ";
msg9 = msg9.TrimEnd();//sondaki boşlukları siler
msg9 = msg.TrimStart();//baştaki boşlukları siler
msg9 = msg9.Trim();//boşlukları siler iki taraftaki 


//String Örnek
//string str = "TÜRKİYE";
//Console.WriteLine(str);
//for (int i = 0; i < str.Length; i++)
//{
//    Console.WriteLine("str[{0}] = {1}", i, str[i]);
//}
//Console.WriteLine(str.IndexOf("TÜRK")); // 0 (arama)
//Console.WriteLine(str.IndexOf("türk")); // -1 (bulunamadı)
//Console.WriteLine(str.Substring(0, 4)); // türk (belirli bir kısmın alınıp geri 
//kalanın atılması)
//Console.WriteLine(str.ToLower()); // türkiye
//Console.WriteLine(str.ToUpper()); // TÜRKİYE
//str = "İlkokul";
//Console.WriteLine(str.Replace("İlk", "Orta")); // OrtaOkul (değişim)

//string ad = "Ahmet";
//string soyad = "AK";
//int yas = 60;
//string adsoyad = ad + " " + soyad + " (yaş: " + yas + ")";
//Console.WriteLine(adsoyad); // Ahmet Ak (yaş:60)
//Console.WriteLine(" \n\n Bilgisayar Mühendisi ".Trim()); // baştaki sondaki 
//boşlukları siler.
//Console.ReadKey()


#endregion
#region 0 ile 100 arasında sayı tahmin etme uygulaması
var tutulanSayi = random.Next(100);
Console.WriteLine("0 ile 100 arasında sayı tahmin ediniz");

while (true)
{
    Console.Write("Sayı giriniz: ");
    var girilenDeger = Console.ReadLine();
    var deger = int.Parse(girilenDeger);

    if (deger == tutulanSayi)
    {
        Console.WriteLine("Tebrikler buldunuz");
        break;
    }
    else if (deger < tutulanSayi)
    {
        Console.WriteLine("Sayıyı büyütün");
    }
    else
        Console.WriteLine("Sayıyı küçültün");
}

Console.WriteLine("Game over");
#endregion
#region Methotlar
public static void EkranaYaz() // geriye değer döndürmeyen
{
    Console.WriteLine("");

}
public static void EkranaMesajYaz(string mesaj)
{
    Console.WriteLine(mesaj);

}

public static double Topla() //geriye değer döndüren
{
    var toplam = 0;
    for (int i = 0; i < 20; i++)
    {
        toplam += i;
    }
    return toplam; //
}
#endregion
#region DateTime
//DateTime dateTime = DateTime.Now;
//DateTime dateTimeUtc = DateTime.UtcNow;
//var bugun = DateTime.Now.Date;
//var bugun2 = DateTime.Today;

//var besGunSonra = dateTime.AddDays(5);
//var besGunOnce = dateTime.AddDays(-5);

//var besAySonra = dateTime.AddMonths(5);
//var altiAyOnce = dateTime.AddMonths(-6);

//var besYilSonra = dateTime.AddYears(5);
//var altiYilOnce = dateTime.AddYears(-6);

//var besSaatSonra = dateTime.AddHours(5);
//var onbesSaatSonra = dateTime.AddHours(15);
//var yirmiSaatOnce = dateTime.AddHours(-20);

//var sinavBitisTarihi = dateTime.AddMinutes(50);

//var onSaniyeSonra = dateTime.AddSeconds(10);

//var yuzMilisaniyeSonra = dateTime.AddMilliseconds(100);


//DateTime tarih = new DateTime(2002, 7, 3);
//DateTime tarih2 = new DateTime(2022, 6, 5, 13, 50, 15);

//string dogumTarihi = "01.11.2000";
//DateTime tarih3 = DateTime.Parse(dogumTarihi);


//var sonuc = DateTime.Today.Subtract(tarih);

//var sonuc2 = DateTime.Today - tarih;

//var ssssss = dateTime.AddHours(10);
//ssssss = ssssss.AddMinutes(30);
//ssssss = ssssss.AddSeconds(50);

//TimeSpan timeSpan = new TimeSpan(10, 30, 50);

//var onSaat30Dakika50SaniyeSonra = dateTime.Add(timeSpan);

//var saat = "11:05:01";
//var eklenecekSaat = TimeSpan.Parse(saat);
//var onbirSaat5Dakika1SaniyeSonra = dateTime.Add(timeSpan);


//var gunsayisi = DateTime.DaysInMonth(2022, 2);
//gunsayisi = DateTime.DaysInMonth(1990, 2);
//gunsayisi = DateTime.DaysInMonth(1990, 1);
//gunsayisi = DateTime.DaysInMonth(1988, 2);
#endregion
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
// Parametre alan ama değer döndürmeyen metot
using System.Reflection.Metadata;

void HosgeldinizMesaji(string isim, string soyisim)
{
    Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
}

Console.WriteLine("İsim giriniz: ");
string isim = Console.ReadLine();

Console.WriteLine("Soy isim giriniz: ");
string soyisim = Console.ReadLine();

HosgeldinizMesaji( isim, soyisim);

Console.WriteLine("--------------------------------");

// Geriye Değer Döndürmeyen Bir void metot.

void SarkiSözü()
{
    Console.WriteLine("Utan! Utan! Utanmayan İnsan Olur Mu Lan ?!");
}

SarkiSözü();
SarkiSözü();
SarkiSözü();

Console.WriteLine("--------------------------");

//Geriye Tamsayı Döndüren Bir metot. Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.

int TamsayiDonduren()
{
    Random rndm = new Random();
    int RastgeleSayi = rndm.Next(1, 101);
    return RastgeleSayi % 2;
}

int kalan = TamsayiDonduren();
Console.WriteLine("Sayının 2'ye bölümünden kalan: " + kalan);

Console.WriteLine("-----------------------------------");

//  Alan ve Geriye Değer Döndüren Bir Metot .Parametre olarak aldığı iki sayının çarpımını geriye dönsün.

int carpimSonucu ( int sayi1, int sayi2 )
{
   return sayi1 * sayi2;
}
Console.WriteLine("1.sayıyı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2.sayıyı giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int sonuc = carpimSonucu( sayi1, sayi2);
Console.WriteLine(sonuc);



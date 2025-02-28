Console.Write("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine()); 
int toplam = 0;

while (sayi != 0) 
{
    toplam = toplam + (sayi % 10); 
    sayi = sayi / 10; 
}

Console.WriteLine("Rakamların toplamı: " + toplam);
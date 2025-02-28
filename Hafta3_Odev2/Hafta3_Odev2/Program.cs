int sayi;
do
{
    Console.Write("10 ile 100 arasında bir sayı giriniz: ");
    sayi = Convert.ToInt32(Console.ReadLine());
} while (sayi < 10 || sayi > 100);

Console.WriteLine("Geçerli sayı girdiniz: " + sayi);
List<int> sayilar = new List<int>();

Console.WriteLine("Lütfen sayıları girin (bitirmek için -1 yazınız):");

while (true)
{
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi == -1)
        break;
    sayilar.Add(sayi);
}

double ortalama = sayilar.Average();
sayilar.Sort();

Console.WriteLine("Ortalama: " + ortalama);
Console.WriteLine("Küçükten büyüğe sıralama: " + string.Join(", ", sayilar));
List<int> sayilar = new List<int>(); 

Console.WriteLine("Sayıları giriniz (Bitirmek için -1 yazın):");

while (true)
{
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi == -1) 
        break;

    sayilar.Add(sayi); 
}


sayilar.RemoveAll(sayi => sayi < 10);

Console.WriteLine("10'dan büyük veya eşit olan sayılar:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}
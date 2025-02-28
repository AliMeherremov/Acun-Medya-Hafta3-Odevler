int[] yaslar = { 5, 16, 25, 70, 45, 12 };

foreach (int yas in yaslar)
{
    if (yas >= 0 && yas <= 12)
        Console.WriteLine(yas + " yaş: Çocuk");
    else if (yas >= 13 && yas <= 19)
        Console.WriteLine(yas + " yaş: Genç");
    else if (yas >= 20 && yas <= 64)
        Console.WriteLine(yas + " yaş: Yetişkin");
    else
        Console.WriteLine(yas + " yaş: Yaşlı");
}
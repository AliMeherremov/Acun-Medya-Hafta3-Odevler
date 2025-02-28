Console.Write("Lütfen bir cümle giriniz: ");
string cumle = Console.ReadLine();

string[] kelimeler = cumle.Split(' ');
Array.Sort(kelimeler);

Console.WriteLine("Alfabetik sıralama:");
foreach (string kelime in kelimeler)
{
    Console.WriteLine(kelime);
}
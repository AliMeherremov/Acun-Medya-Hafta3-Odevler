string[] kelime = { "acunmedya", "lumos", "yeşil", "ödev", "araba" }; //dizi dediğiniz için kullanıcıdan girdi istemedim sadece random kelimeler attım

string enUzun = kelime.OrderByDescending(k => k.Length).First();
string enKisa = kelime.OrderBy(k => k.Length).First();

Console.WriteLine("En uzun kelime: " + enUzun);
Console.WriteLine("En kısa kelime: " + enKisa);
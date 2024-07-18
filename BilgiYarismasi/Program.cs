Console.WriteLine("Darth Vader'ın gerçek ismi nedir?\n A-) Anakin Skywalker     B-) Qui-Gon Jinn");
string cevap = Console.ReadLine().ToLower();
int dogruCevap = 0;
//ilk soruyu kontrol ediyoruz doğruysa doğru cevap sayımız 1 artıyor.
if(cevap == "a")
{
    Console.WriteLine("Tebrikler Dogru cevap!");
    dogruCevap++;
}
else
{
    Console.WriteLine("Yanlıs Cevapladınız");
    
}
//ikinci soruyu kontrol ediyoruz doğruysa doğru cevap sayımız 1 artıyor.
Console.WriteLine("Mars da bulunan Jezero kraterine benzeyen gölümüz hangisidir?\n A-) Salda Gölü     B-) Tortum Gölü");
string cevap2 = Console.ReadLine().ToLower();
if(cevap2 == "a")
{
    Console.WriteLine("Tebrikler Dogru cevap!");
    dogruCevap++;
}
else
{
    Console.WriteLine("Yanlıs Cevapladınız");
}
//kullanıcı iki tane dogru cevap verdiyse 1 milyon TL kazanıyor ve program duruyor.
if(dogruCevap == 2)
{
    Console.WriteLine("1 Milyon TL Kazandınız");
    return;
}
//kullanıcı hiç doğru cevap veremediyse eleniyor ve program duruyor.
if(dogruCevap < 1)
{
    Console.WriteLine("2 Soruyu yanlış cevapladınız ve elendiniz.");
    return;
}
//kullanıcı 1 doğru 1 yanlıs cevap verdiyse 3.soruyu cevaplıyor.
Console.WriteLine(" Dünya'ya en yakın gezegen hangisidir ? \n A-) Mars     B-) Venüs");
string cevap3 = Console.ReadLine().ToLower();
if(cevap3 == "b")
{
    Console.WriteLine("1 Milyon TL Kazandınız");
}
else
{
    Console.WriteLine("2 Soruyu yanlış cevapladınız ve elendiniz.");
}
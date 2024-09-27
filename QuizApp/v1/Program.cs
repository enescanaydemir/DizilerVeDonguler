namespace v1;

class Program
{
    static void Main(string[] args)
    {
        string[] sorular = ["Gökyüzü ne renktir?", "Türkiye'nin başkenti neresidir?"];
        string[] cevaplar = ["Mavi", "Ankara"];
        string[] secenekler = ["Kırmızı|Mavi|Pembe|Mor", "Ankara|İstanbul|İzmir"];


        int dogruSayisi = 0;
        int yanlisSayisi = 0;


        for (int i = 0; i < sorular.Length; i++)
        {
            Console.WriteLine(sorular[i]);

            string[] secenek = secenekler[i].Split('|');
            for (int j = 0; j < secenek.Length; j++)
            {
                Console.WriteLine($"{j + 1}. Secenek: {secenek[j]}");
            }

            Console.Write("Doğru Cevap Numarasını Giriniz: ");
            int secim = int.Parse(Console.ReadLine());

            string kullaniciCevap = secenek[secim - 1];

            if (kullaniciCevap.Equals(cevaplar[i]))
            {
                Console.Write("\nDoğru Cevap!\n");
                dogruSayisi++;
            }
            else
            {
                Console.WriteLine($"\nCevabınız yanlış! Doğru Cevap: {cevaplar[i]}\n");
                yanlisSayisi++;
            }
        }
        Console.WriteLine($"Toplam Doğru Sayısı: {dogruSayisi}");
        Console.WriteLine($"Toplam Yanlış Sayısı: {yanlisSayisi}");
    }
}

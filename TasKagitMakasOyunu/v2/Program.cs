namespace v2;

class Program
{
    static void Main(string[] args)
    {
        string[] secenekler = {"Taş", "Kağıt", "Makas"};
        Random rastgele = new Random();
        bool devam = true;
        
        Console.Write("Taş-Kağıt-Makas Oyunu Başladı!\n");

        while (devam)
        {
            Console.Write("Lütfen seçiminizi yapınız (Çıkış içim 'çıkış' yazınız): ");
            string kullaniciSecimi = Console.ReadLine();

            if (kullaniciSecimi == "çıkış")
            {
                devam = false;
                Console.WriteLine("Çıkış yapılıyor!");
                break;
            }

            string bilgisayarSecimi = secenekler[rastgele.Next(secenekler.Length)];
            Console.WriteLine($"Bilgisayarın seçimi: {bilgisayarSecimi}");

            if (kullaniciSecimi == bilgisayarSecimi)
            {
                Console.WriteLine("Beraberlik!");
            }
            else if ((kullaniciSecimi == "Taş" && bilgisayarSecimi == "Makas") || 
                    (kullaniciSecimi == "Makas" && bilgisayarSecimi == "Kağıt") || 
                    (kullaniciSecimi == "Kağıt" && bilgisayarSecimi == "Taş"))
            {
                Console.WriteLine("Kazandınız! Tebrikler!");
            }
            else
            {
                Console.WriteLine("Kaybettiniz!");
            }
        }
    }
}


/*

v1
- string dizisi içinde taş kağıt makas seçenekleri olsun. 
- kullanıcıya hangi seçeneği seçtiğini sorun
- durumlara bağlı olarak kazandın veya kaybettin deyin

*/
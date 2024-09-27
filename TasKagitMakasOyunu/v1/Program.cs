namespace v1;

class Program
{
    static void Main(string[] args)
    {
        string[] secenekler = {"Taş", "Kağıt", "Makas"};
        Random rastgele = new Random();


        Console.WriteLine("Taş-Kağıt-Makas Oyunu Başladı!\nLütfen seçiminizi yapınız: ");
        string kullaniciSecimi = Console.ReadLine();

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


/*

v1
- string dizisi içinde taş kağıt makas seçenekleri olsun. 
- kullanıcıya hangi seçeneği seçtiğini sorun
- durumlara bağlı olarak kazandın veya kaybettin deyin

*/
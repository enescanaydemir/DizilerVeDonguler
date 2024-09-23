namespace v2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi yazınız (Toplama, Çıkarma, Çarpma, Bölme)");
        string islem = Console.ReadLine();

        Console.Write("Kaç adet rakam ile işlem yapacaksınız ?: ");
        int rakamAdedi = int.Parse(Console.ReadLine());

        double sonuc = 0;
        bool ilkGiris = true;

        for (int i = 0; i < rakamAdedi; i++)
        {
            Console.Write($"{i + 1}. rakamı giriniz: ");
            double rakam = double.Parse(Console.ReadLine());

            if (ilkGiris)
            {
                sonuc = rakam; //sonucu rakama eşitledim çünkü ilk alınan sayıyı bir işleme dahil etmeden direkt girilen rakamla yani sıradaki sayıyla işleme sokacağız
                ilkGiris = false; //burda da false yapıp geri dönüşü kapatıyorum
            }
            else
            {
                switch (islem)
                {
                    
                    case "Toplama":
                        sonuc += rakam;
                        break;
                    case "Çıkarma":
                        sonuc -= rakam;
                        break;
                    case "Çarpma":
                        sonuc *= rakam;
                        break;
                    case "Bölme":
                        if (rakam == 0)
                        {
                            Console.WriteLine("Sıfıra bölünemez! Lütfen yeniden rakam giriniz");
                            i--; //kullanıcı 0 girişi yaptığında i yi 1 azaltıp yeniden rakam girmesini sağladım
                            continue;
                        }
                        sonuc /= rakam;
                        break;
                }
            }
        }
        Console.WriteLine($"Girilen işlem sonucu: {sonuc}");
    }
}


/*

v2
- Kullanıcıya önce liste ile hangi matematik işlemi yapmak istediğini soralım.
- Kaç adet rakam ile işlem yapacağını soralım.
- Sonucu gösterelim

*/
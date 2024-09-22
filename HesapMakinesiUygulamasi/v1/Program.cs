namespace v1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kaç adet rakam toplamak istiyorsunuz ?");
        int rakamAdedi = int.Parse(Console.ReadLine());

        int rakamlarToplami = 0;

        for (int i = 0; i < rakamAdedi; i++)
        {
            Console.WriteLine("Sayiyi giriniz: ");
            int rakam = int.Parse(Console.ReadLine());

            rakamlarToplami += rakam;
        }

        double rakamlarOrtalamasi = rakamlarToplami / rakamAdedi;

        Console.WriteLine($"Toplam: {rakamlarToplami}");
        Console.WriteLine($"Ortalama: {rakamlarOrtalamasi}");
    }
}

/*

v1
- Kullanıcıya kaç adet rakam toplamak istediğini soralım.
- Girdiği rakamlara göre toplam ve ortalama sonuç gösterelim.


Cikti:
    Kaç adet rakam toplamak istiyorsunuz ?
    5
    Sayiyi giriniz: 
    1
    Sayiyi giriniz: 
    3
    Sayiyi giriniz: 
    5
    Sayiyi giriniz: 
    7
    Sayiyi giriniz: 
    9
    Toplam: 25
    Ortalama: 5
*/
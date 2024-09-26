namespace v2;

class Program
{
    static void Main(string[] args)
    {
        string[] urunler = ["Kola", "Bira", "Süt", "Soda", "Meyve Suyu", "Ekmek", "Yağ", "Un", "Domates", "Biber", "Patlıcan"];
        int[] fiyatlar = [10, 90, 50, 80, 20, 55, 70, 100, 30, 60, 15];


        int toplamFiyat = 0;
        List<string> alinanUrunler = new List<string>(); //alınan ürünleri tutan liste
        bool devam = true;

        Console.WriteLine("Markette Bulunan Ürünler ve Fiyatları");

        for (int i = 0; i < urunler.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {urunler[i]} -> {fiyatlar[i]} TL");
        }

        Console.Write("Kaç adet ürün alacağınızı belirtin: \n");
        int urunAdet = int.Parse(Console.ReadLine());


        for (int i = 0; i < urunAdet; i++)
        {
            Console.Write($"{i + 1}. ürünü giriniz: ");
            string urunSecim = Console.ReadLine();

            bool urunBulundu = false;
            for (int j = 0; j < urunler.Length; j++)
            {
                if (urunSecim.Equals(urunler[j]))
                {
                    alinanUrunler.Add(urunler[j]); //normalde burda benim ilk yaptığım direkt kullanıcıdan aldığımız urunSecim değişkeninde tuttuğumuz urunleri atamaktı fakat yukarıda döngünün içinde bir eleme yapıoyruz eğer urunler içerisinde varsa alinanUrunlere ekliyoruz. direkt atama yaparsak kullanıcı doğru yanlış ne yazarsa yazsın atanacağı için onun önüne geçiyoruz.
                    toplamFiyat += fiyatlar[j]; //seçilen ürünün fiyatını toplamFiyat değişkenine ekledik.
                    urunBulundu = true;
                    Console.WriteLine($"{urunler[j]} sepete eklendi. Şu anki toplam: {toplamFiyat} TL");
                    break;
                }
            }
            if (!urunBulundu) //burda kullanıcı geçersiz bir ürün girerse urunBulundu false ihtimalini bir döngüde kullanıyoruz.
            {
                Console.WriteLine("Geçersiz ürün ismi girdiniz. Lütfen doğru bir ürün giriniz!");
                i--; //ürün hatalı girerse (üstteki for döngüsü için) tekrar ürün isteme amacıyla ürün sayacını geri alıyoruz.
            }
        }
        Console.WriteLine("Aldığınız ürünler: ");
        foreach (var urun in alinanUrunler)
        {
            Console.WriteLine(urun);
        }
        Console.WriteLine($"Toplam ödemeniz gereken tutar: {toplamFiyat} TL");
    }
}


/*

v2
- En az 10 tane ürün gösterelim
- Kullanıcı kaç adet ürün almak istediğini seçsin
- İşlemler tamamlandığında kullanıcıya neleri aldığını ve toplam tutarı söyleyelim

*/
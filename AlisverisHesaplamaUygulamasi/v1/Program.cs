namespace v1;

class Program
{
    static void Main(string[] args)
    {
        string[] urunler = ["Süt", "Yumurta", "Ekmek", "Un", "Yağ"];
        int[] fiyatlar = [10, 65, 85, 50, 120];

        int toplamFiyat = 0;
        bool devam = true;

        Console.WriteLine("Markette bulunan Ürünler ve Fiyatları");


        for (int i = 0; i < urunler.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {urunler[i]} -> {fiyatlar[i]} TL");
        }

        Console.Write("Alışveriş yapmak istediğiniz ürünün ismini giriniz (İşemi bitirmek için 't' tuşlayınız!");
    
        while (devam)
        {
            Console.Write("\nSeçmek istediğiniz ürün ismini giriniz: ");
            string urunSecim = Console.ReadLine();

            if (urunSecim.ToLower() == "t")
            {
                devam = false;
                break;
            }

            bool urunBulundu = false;
            for (int i = 0; i < urunler.Length; i++)
            {
                if (urunSecim.Equals(urunler[i], StringComparison.OrdinalIgnoreCase)) //Equals metodu iki string değerini karşılaştırır. Kullanıcıdan gelen urunSecim ile urunler dizisindeki her bir ürünün adını karşılaştırdık. Eğer iki string eşit ise sonuç true, değil ise false döner. StringComparison.OrdinalIgnoreCase parametresi Equals metodunun büyük küçük harf farkını göz ardı ederek karşılaştırma yapmasını sağlar.
                {
                    toplamFiyat += fiyatlar[i]; //seçilen ürünün fiyatını toplamFiyat ile topladık ve atadık.
                    Console.WriteLine($"{urunler[i]} sepete eklendi. Güncel Toplam Fiyat: {toplamFiyat} TL");
                    urunBulundu = true;
                    break;
                }
            }

            if (!urunBulundu)
            {
                Console.WriteLine("Geçersiz ürün ismi girdiniz. Lütfen doğru bir ürün ismi giriniz!");
            }
        }
        Console.WriteLine($"Toplam ödemeniz gereken tutar: {toplamFiyat} TL");
    }
}

/*

- Kullanıcıya hazır ürünler çıkaralım. Örneğin market alışverinde olabilecek şeyler. Paralel dizi ile fiyatlarını da listeyelim.
- Kullanıcı hangi ürünleri istiyorsa onun fiyatını toplam fiyata ekleyelim. eğer t harfini girerse toplam gösterip sonuçlandıralım


*/
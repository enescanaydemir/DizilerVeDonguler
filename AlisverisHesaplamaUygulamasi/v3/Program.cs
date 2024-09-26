namespace v3;

class Program
{
    static void Main(string[] args)
    {
        string[] urunler = ["Kola", "Bira", "Süt", "Soda", "Meyve Suyu", "Ekmek", "Yağ", "Un", "Domates", "Biber", "Patlıcan"];
        int[] fiyatlar = [10, 90, 50, 80, 20, 55, 70, 100, 30, 60, 15];

        int toplamFiyat = 0;
        List<string> alinanUrunler = new List<string>();
        bool devam = true;

        Console.WriteLine("Market Ürünleri ve Fiyatları");
        
        for (int i = 0; i < urunler.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {urunler[i]} -> {fiyatlar[i]} TL");
        } 


        Console.Write("Kaç adet ürün almak istersiniz: ");
        int urunAdet = int.Parse(Console.ReadLine());

        for (int i = 0; i < urunAdet; i++)
        {
            Console.Write($"Almak istediğiniz {i + 1}. ürünü giriniz: ");
            string urunSecim = Console.ReadLine();

            bool urunDogrulama = false;
            for (int j = 0; j < urunler.Length; j++)
            {
                if (urunSecim.Equals(urunler[j]))
                {
                    alinanUrunler.Add(urunler[j]);
                    toplamFiyat += fiyatlar[j];
                    urunDogrulama = true;
                    Console.WriteLine($"{urunler[j]} sepete eklendi. Şu anki toplam fiyat: {toplamFiyat} TL");
                    break;
                }
            }
            if (!urunDogrulama)
            {
                Console.WriteLine("Geçersiz ürün ismi girdiniz. lütfen doğru giriş yapınız!");
            }
            Console.WriteLine("\nAldığınız Ürünler");
            foreach (var urun in alinanUrunler)
            {
                Console.WriteLine(urun);
            }
            Console.WriteLine($"\nToplam ödemeniz gereken tutar: {toplamFiyat} TL");
        }
        Console.Write("\nÖdemeniz gereken tutarı giriniz: ");
        int odenenTutar = int.Parse(Console.ReadLine());

        if (odenenTutar > toplamFiyat)
        {
            int paraUstu = odenenTutar - toplamFiyat;
            Console.WriteLine($"Ödediğiniz tutar: {odenenTutar}\nPara üstü: {paraUstu}");
        }
        else if (odenenTutar == toplamFiyat)
        {
            Console.WriteLine($"Ödediğiniz tutar: {odenenTutar}\nÖdemeniz başarıyla gerçekleştirilmiştir!");
        }
        else
        {
            int eksikTutar = toplamFiyat - odenenTutar;
            Console.WriteLine($"Ödenen Tutar: {odenenTutar}\nÖdenmesi Gereken Tutar: {toplamFiyat}\n{eksikTutar} TL Eksik ödeme yaptınız.");
        }
    }
}


/*

v2
- En az 10 tane ürün gösterelim
- Kullanıcı kaç adet ürün almak istediğini seçsin
- İşlemler tamamlandığında kullanıcıya neleri aldığını ve toplam tutarı söyleyelim

v3
- Kullanıcıya para üstü bilgisi vermek adına ödediği tutarı da girelim
*/


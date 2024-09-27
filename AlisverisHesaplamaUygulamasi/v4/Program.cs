namespace v4;

class Program
{
    static void Main(string[] args)
    {
        string[] urunler = ["Kola", "Bira", "Süt", "Soda", "Meyve Suyu", "Ekmek", "Yağ", "Un", "Domates", "Biber", "Patlıcan"];
        int[] fiyatlar = [10, 90, 50, 80, 20, 55, 70, 100, 30, 60, 15];
        int[] stok = [5, 3, 7, 9, 11, 4, 2, 1, 8, 10, 6];

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
            bool urunSecildi = false;

            while (!urunSecildi)
            {
                Console.Write($"Almak istediğiniz {i + 1}. ürünü giriniz: ");
                string urunSecim = Console.ReadLine();

                for (int j = 0; j < urunler.Length; j++)
                {
                    if (urunSecim.Equals(urunler[j]))
                    {

                        Console.Write($"{urunSecim} Ürününden kaç adet almak istersiniz ? Stok: ({stok[j]}): ");
                        int stokAdet = int.Parse(Console.ReadLine());

                        if (stokAdet > stok[j])
                        {
                            Console.WriteLine($"Maalesef {urunler[j]} ürününden yalnızca {stok[j]} adet ürün bulunmaktadır. Lütfen geçerli bir ürün adedi giriniz!");
                            break;
                        }
                        else
                        {
                            alinanUrunler.Add(urunler[j]);
                            toplamFiyat += fiyatlar[j];
                            stok[j] -= stokAdet;

                            Console.WriteLine($"{urunler[j]} sepete eklendi. Şu anki toplam fiyat: {toplamFiyat} TL");
                            urunSecildi = true;
                        }
                        break;
                    }
                }
            }

            if (!urunSecildi)
            {
                Console.WriteLine("Geçersiz ürün ismi girdiniz. lütfen doğru giriş yapınız!");
            }
        }

        Console.WriteLine("\nAldığınız Ürünler");
        foreach (var urun in alinanUrunler)
        {
            Console.WriteLine(urun);
        }
        Console.WriteLine($"\nToplam ödemeniz gereken tutar: {toplamFiyat} TL");


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

v4
- Ürünlerin stok durumlarını da ayrı bir paralel dizide tutalım. Ekleme yapılırken adet girişi de yapılsın.

*/


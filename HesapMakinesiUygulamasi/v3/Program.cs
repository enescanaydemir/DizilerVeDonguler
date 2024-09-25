namespace v3;

class Program
{
    static void Main(string[] args)
    {
        
        double sonuc = 0;
        bool devam = true; //while için döngü kontrolü belirledim

        Console.WriteLine("Uygulamadan çıkmak için 'e tuşlayınız!");
        while (devam)
        {
            
            Console.Write("Birinci rakamı girin: ");
            string firstNumOrInp = Console.ReadLine();

            //aşağıdaki döngüde kullanıcı e girerse yukarıda devam değişkenini false yapıp döngüyü baştan bitiriyoruz.
            if (firstNumOrInp.ToLower() == "e")
            {
                devam = false;
                break;
            }
            
            double firstNum = double.Parse(firstNumOrInp);//burda da kullanıcı eğer e girmediyse double değerine çevirip rakam değişkenine atıyoruz.


            Console.Write("İkinci rakamı girin: ");
            string secondNumOrInp = Console.ReadLine();

            
            if (secondNumOrInp.ToLower() == "e")
            {
                devam = false;
                break;
            }
            
            double secondNum = double.Parse(secondNumOrInp);
            
            Console.Write("Yapmak istediğiniz işlemi seçiniz(Toplama, Çıkarma, Çarpma, Bölme): ");
            string islem = Console.ReadLine();

            switch (islem)
            {
                
                case "Toplama":
                    sonuc = firstNum + secondNum;
                    break;
                case "Çıkarma":
                    sonuc = firstNum - secondNum;
                    break;
                case "Çarpma":
                    sonuc = firstNum * secondNum;
                    break;
                case "Bölme":
                    if (secondNum == 0)
                    {
                        Console.WriteLine("Sıfıra bölünemez! Lütfen 0'dan başka rakam giriniz.");
                        continue; //buraya ilk başta bunu eklemedim. Eklemeyince bu uyarıyı verse bile önceki işlemin sonucunu basıyordu. Ekledikten sonra 2. rakam 0 olsa bile sadece uyarıyı veriyor ve sonucu vermeden devam ediyor döngüye.
                    }
                    else
                    {
                        sonuc = firstNum / secondNum;
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz bir işlem seçimi yaptınız.");
                    break;
            }
            Console.WriteLine("Sonucunuz: " + sonuc);
        }
        Console.WriteLine("Programdan çıkış yapıldı. Tekrar bekleriz!");
    }
}



/*

v3
- Kullanıcı rakam girip yapmak istediği işlemi seçsin.
Örneğin 5 girsin sonra toplama işlemi için seçim yapsın.
Her işlem sonrasında sonucu ekranda göstermeliyiz.
Kullanıcı "e" girmediği sürece hesaplama işlemi devam etsin

*/
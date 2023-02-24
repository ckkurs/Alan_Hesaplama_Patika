using System;

namespace Alan_Hesaplama
{
    class Program
    {
        static  void Main(string[] args)
        {
            double pi=3.14;
            double cevre;
            double yaricap;
            double alan;
            int uzunkenar;
            int kısakenar;
            int yukseklik;
            Console.WriteLine("İşlem yapmak istediğiniz geometrik şekli seçiniz:");
            Console.WriteLine("1-Daire");
            Console.WriteLine("2-Üçgen");
            Console.WriteLine("3-Dikdörtgen");
            
            int deger=int.Parse(Console.ReadLine());

            if(deger==1)
            {
                Console.WriteLine("Hangi İşlemi Yapmak İstersiniz Seçiniz");
                Console.WriteLine("1-Çevre");
                Console.WriteLine("2-Alan");
                int deger2=int.Parse(Console.ReadLine());
                switch(deger2)
                {
                    case 1:
                      Console.WriteLine("Dairenin Yarıçapını Giriniz: ");
                      yaricap =int.Parse(Console.ReadLine());
                      cevre=2*pi*yaricap;
                      Console.WriteLine("Dairenin Çevresi: " + cevre);
                    break;
                    case 2:
                      Console.WriteLine("Dairenin Yarıçapını Giriniz: ");
                      yaricap = int.Parse(Console.ReadLine());
                      alan = pi*yaricap*yaricap;
                      Console.WriteLine("Dairenin Alanı: " + alan);
                    break;
                    default:
                      Console.WriteLine("Yanlış Tuşlama Yaptınız.");
                      Console.WriteLine("Yeniden Tuşlama Yapınız. ");
                    break;
                }
            }
            else if(deger==2)
            {
                Console.WriteLine("Hangi İşlemi Yapmak İstersiniz Seçiniz");
                Console.WriteLine("1-Çevre");
                Console.WriteLine("2-Alan");
                int deger3=int.Parse(Console.ReadLine());
                switch(deger3)
                {
                    case 1:
                      Console.WriteLine("Üçgenin 1.Kenarını Giriniz: ");
                      int a=int.Parse(Console.ReadLine());
                      Console.WriteLine("Üçgenin 2.Kenarını Giriniz: ");
                      int b=int.Parse(Console.ReadLine());
                      Console.WriteLine("Üçgenin 3.Kenarını Giriniz: ");
                      int c=int.Parse(Console.ReadLine());
                      cevre=a+b+c;
                      Console.WriteLine("Üçgenin Çevresi: " + cevre);
                    break;
                    case 2:
                      Console.WriteLine("Üçgenin Taban Uzunluğunu Giriniz: ");
                      int taban=int.Parse(Console.ReadLine());
                      Console.WriteLine("Üçgenin Yükseklik Uzunluğunu Giriniz: ");
                      yukseklik=int.Parse(Console.ReadLine());
                      alan=(taban*yukseklik)/2;
                      Console.WriteLine("Üçgenin Alanı: " + alan);
                    break;
                    default:
                      Console.WriteLine("Yanlış Tuşlama Yaptınız.");
                      Console.WriteLine("Yeniden Tuşlama Yapınız. ");
                    break;
                }
            }
            else if(deger==3)
            {
                Console.WriteLine("Hangi İşlemi Yapmak İstersiniz Seçiniz");
                Console.WriteLine("1-Çevre");
                Console.WriteLine("2-Alan");
                Console.WriteLine("3-Hacim");
                int deger3=int.Parse(Console.ReadLine());
                switch(deger3)
                {
                    case 1:
                      Console.WriteLine("Dikdörtgenin Uzun Kenar Uzunluğunu Giriniz: ");
                      uzunkenar=int.Parse(Console.ReadLine());
                      Console.WriteLine("Dikdörtgenin Kısa Kenar Uzunluğunu Giriniz: ");
                      kısakenar=int.Parse(Console.ReadLine());
                      cevre=2*kısakenar+2*uzunkenar;
                      Console.WriteLine("Dikdörtgenin Çevresi: " + cevre);
                    break;
                    case 2:
                      Console.WriteLine("Dikdörtgenin Uzun Kenar Uzunluğunu Giriniz: ");
                      uzunkenar=int.Parse(Console.ReadLine());
                      Console.WriteLine("Dikdörtgenin Kısa Kenar Uzunluğunu Giriniz: ");
                      kısakenar=int.Parse(Console.ReadLine());
                      alan=kısakenar*uzunkenar;
                      Console.WriteLine("Dikdörtgenin Alanı: " + alan);
                    break;
                    case 3:
                      Console.WriteLine("Dikdörtgenin Uzun Kenar Uzunluğunu Giriniz: ");
                      uzunkenar=int.Parse(Console.ReadLine());
                      Console.WriteLine("Dikdörtgenin Kısa Kenar Uzunluğunu Giriniz: ");
                      kısakenar=int.Parse(Console.ReadLine());
                      Console.WriteLine("Dikdörtgenin Yüksekliğini Giriniz: ");
                      yukseklik=int.Parse(Console.ReadLine());
                      int hacim=uzunkenar*kısakenar*yukseklik;
                    break;
                    default:
                      Console.WriteLine("Yanlış Tuşlama Yaptınız.");
                      Console.WriteLine("Yeniden Tuşlama Yapınız. ");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Yanlış Tuşlama Yaptınız.");
                Console.WriteLine("Yeniden Tuşlama Yapınız. ");
            }
        }
    }
}

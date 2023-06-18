namespace matematikmenüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matematik Menüsüne Hoşgeldiniz");
            Console.WriteLine();
            Console.WriteLine("***************** Menü *****************");
            Console.WriteLine("1- Aritmetik dört işlem");
            Console.WriteLine("2- Üs alma");
            Console.WriteLine("3- Kök alma");
            Console.WriteLine("4- Karenin çevre ve alan hesabı");
            Console.WriteLine("5- Dikdörtgenin alan ve çevre hesabı");
            Console.WriteLine("6- Eşkenar üçgende çevre");
            Console.WriteLine("****************************************");
            Console.WriteLine();
            int islem;
            Console.Write("İşlem Yapmak İstediğiniz Menüyü Tuşlayın: ");
            islem = Convert.ToInt16(Console.ReadLine());
            if (islem == 1)
            {
                int a, b, toplam, fark, carpim, bolum;
                Console.Write("1.Sayıyı Giriniz:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Sayıyı Giriniz:");
                b = Convert.ToInt32(Console.ReadLine());
                toplam = a + b;
                fark = a - b;
                carpim = a * b;
                bolum = a / b;
                Console.WriteLine("Toplam: " + toplam);
                Console.WriteLine("Fark: " + fark);
                Console.WriteLine("Carpim: " + carpim);
                Console.WriteLine("Bölüm: " + bolum);
            }
            if (islem == 2)
            {
                double sayi, us, sonuc;
                Console.Write("Sayıyı Giriniz: ");
                sayi = Convert.ToDouble(Console.ReadLine());
                Console.Write("Üssü Giriniz: ");
                us = Convert.ToDouble(Console.ReadLine());
                sonuc = Math.Pow(sayi, us);
                Console.WriteLine("Sonuç: " + sonuc);
            }
            if (islem == 3)
            {
                double sayi, kok;
                Console.Write("Kökü Dönüştürülecek Sayıyı Giriniz: ");
                sayi = Convert.ToDouble(Console.ReadLine());
                kok = Math.Sqrt(sayi);
                Console.WriteLine("Sonuç: " + kok);
            }
            if (islem == 4)
            {
                // alan =knar*knar. cevre= kenr*4
                int kenar, alan, cevre;
                Console.Write("Karenin Kenar Uzunluğunu Giriniz: ");
                kenar = Convert.ToInt16(Console.ReadLine());
                alan = kenar * kenar;
                cevre = kenar * 4;
                Console.WriteLine("Alan: " + alan);
                Console.WriteLine("Çevre: " + cevre);
            }
            if (islem == 5)
            {
                int kiske, uzunke, dikcev, dikalan;
                Console.Write("Kısa Kenarı Giriniz: ");
                kiske = Convert.ToInt16(Console.ReadLine());
                Console.Write("Uzun Kenar: ");
                uzunke = Convert.ToInt16(Console.ReadLine());
                dikcev = kiske + kiske + uzunke + uzunke;
                dikalan = kiske * uzunke;
                Console.WriteLine("Dikdörtgenin Alanı: " + dikalan);
                Console.WriteLine("Dikdörtgenin Çevresi: " + dikcev);
            }
            if (islem == 6)
            {
                int kenarr, cevree;
                Console.Write("Kenar Değeri: ");
                kenarr = Convert.ToInt16(Console.ReadLine());
                cevree = kenarr * 3;
                Console.WriteLine("Çevre: " + cevree);
            }
            Console.ReadLine();
        }
    }
}
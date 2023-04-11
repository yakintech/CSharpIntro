

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Lutfen bır sayı gırınız");
        //int sayi = Convert.ToInt32(Console.ReadLine());

        //disaridan girilen sayi 100 den buyukse ekrana sayi cok buyuk yazsin

        //if (sayi > 100)
        //    Console.WriteLine("Sayi cok buyuk");

        //if (sayi > 100)
        //{
        //    Console.WriteLine("Sayi cok buyuk");
        //}

        //Disaridan bir fiyat gir. Eger fiyat 200 den buyukse kdv 18 hesaplasin kucukse 8 hesaplasin ve KDV tutarini ekranda gostersin

        Console.WriteLine("Lutfen fiyat giriniz");
        decimal fiyat = Convert.ToDecimal(Console.ReadLine());

        decimal kdv = 0;
        if (fiyat >= 200)
        {
            kdv = fiyat * 0.18M;
        }
        else
        {
            kdv = fiyat * 0.08M;

        }

        Console.WriteLine(kdv);


        //Disaridan bir ogrenci notu gir. not 70 den buyukse gecti yazsin degilse kaldi yazsin. not 0 dan kucuk veya 100 den buyuk olamaz

    }
}
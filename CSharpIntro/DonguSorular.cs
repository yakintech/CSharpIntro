

//string[] sehirler = new string[2];

//sehirler[0] = "Erzurum";
//sehirler[1] = "Diyarbakir";


//string[] ulkeler = { "Turkiye", "Almanya", "Yunanistan", "Iran", "Bulgaristan" };
////ulkeler[0] = "Rusya";

//Console.WriteLine(ulkeler[0]);

////Dizide kac eleman var?
//Console.WriteLine(ulkeler.Length);


////Ulkeler dizisini ekrana yaz
//for (int i = 0; i < ulkeler.Length; i++)
//{
//    Console.WriteLine(ulkeler[i]);
//}


//int[] sayilar = { 5, 11, -2, 254, 7878, 1, -22, 34, -999, 987 };

//int enbuyuk = 0;
//for (int i = 0; i < sayilar.Length; i++)
//{
//    if (enbuyuk < sayilar[i])
//    {
//        enbuyuk = sayilar[i];
//    }
//}

////Console.WriteLine(enbuyuk);

////Ulkeler dizisindeki tum ulkeleri BUYUK HARF YAP

//for (int i = 0; i < ulkeler.Length; i++)
//{
//    ulkeler[i] = ulkeler[i].ToUpper();
//}


////Kullanicidan 5 adet sayi girmesini ISTIYORUM. Bu sayilarin ortalamasini ekrana yazdir.

//double toplam = 0;
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Lutfen bir sayi giriniz");
//    double sayi = Convert.ToDouble(Console.ReadLine());
//    toplam = toplam + sayi;
//}

//Console.WriteLine(toplam / 5);



////Disaridan girdigi sayi 100 den buyuk olmadigi muddetce tekrar sayi girmesini isteyelim

//bool devamMi = true;

//while (devamMi)
//{
//    Console.WriteLine("Sayi giriniz");
//    int sayi = Convert.ToInt32(Console.ReadLine());

//    if (sayi >= 100)
//        devamMi = false;
//}



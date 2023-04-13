//Disaridan girdigi sayi 100 den buyuk olmadigi muddetce tekrar sayi girmesini isteyelim

//bool devamMi = true;

//while (devamMi)
//{
//	Console.WriteLine("Sayi giriniz");
//	int sayi = Convert.ToInt32(Console.ReadLine());

//	if(sayi > 100)
//		devamMi= false;
//}



//Disaridan girdigi sayi 100 den buyuk olmadigi muddetce tekrar sayi girmesini isteyelim FOR ILE YAP!

for (int i = 0; i < 1; i++)
{
    Console.WriteLine("Sayi giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi < 100)
        i--;
        
}







string[] sehirler = new string[2];

sehirler[0] = "Erzurum";
sehirler[1] = "Diyarbakir";


string[] ulkeler = { "Turkiye", "Almanya", "Yunanistan", "Iran","Bulgaristan" };
//ulkeler[0] = "Rusya";

Console.WriteLine(ulkeler[0]);

//Dizide kac eleman var?
Console.WriteLine(ulkeler.Length);


//Ulkeler dizisini ekrana yaz
for (int i = 0; i <= ulkeler.Length; i++)
{
    Console.WriteLine(ulkeler[i]);
}


int[] sayilar = { 5, 11, -2, 254, 7878, 1, -22, 34, -999, 987 };


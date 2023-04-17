

//1-100 arasinda 10 tane rastgele sayi uret ve bunu bir listeye koy. SAYILAR OZGUN OLMALI. Ayni sayi iki defa olamaz

//List<int> numbers = new List<int>();

//for(int i = 0;i < 10; i++)
//{
//    Random rnd = new Random();
//    int randomNumber = rnd.Next(100);

//    bool hasNumber = numbers.Contains(randomNumber);

//    if (hasNumber)
//    {
//        i--;
//    }
//    else
//    {
//        numbers.Add(randomNumber);
//    }
//}



//DateTime date = DateTime.Now;
//Console.WriteLine(date); // 4/17/2023 10:47:52 AM

DateTime date2 = new DateTime(2022, 12, 20);
Console.WriteLine(date2);



//20 gun sonra gunlerden ne? carsamba mi persembe mi?
DateTime date = DateTime.Now;
DateTime newDate = date.AddDays(20);

Console.WriteLine(newDate.DayOfWeek);


//23 Nisandan bugune kac gun gecti
DateTime newDate3 = new DateTime(1920, 4, 23);
TimeSpan timespan = DateTime.Now - newDate3;

Console.WriteLine(timespan.TotalDays);




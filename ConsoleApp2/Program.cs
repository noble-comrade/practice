// Программа для определения знака зодиака
void zodiacSign(string[] arr)
{
    int day = Convert.ToInt32(arr[0]);
    int month = Convert.ToInt32(arr[1]);
  
    int[] April = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19};    
    int[] May = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};    
    int[] June = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};    
    int[] July = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };    
    int[] August = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };  
    int[] September = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };  
    int[] October = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };   
    int[] November = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };   
    int[] December = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };   
    int[] January = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };   
    int[] February = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
    int[] March = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

    int Chek(int[] arr, int day)
    { 
        foreach (int i in arr) 
        {
            if (i == day) return 1;
        }
        return 0;
    }

    switch (month) 
    {
        case 1:
            if (Chek(January, day) == 1)
            {
                Console.WriteLine("Вы Козерог!");
            }
            else Console.WriteLine("Вы Водолей!");
            break;
        case 2:
            if (Chek(February, day) == 1) 
            {
                Console.WriteLine("Вы Водолей!");
            }
            else Console.WriteLine("Вы Рыба!");
            break;
        case 3:
            if (Chek(March, day) == 1)
            {
                Console.WriteLine("Вы Рыба!");
            }
            else Console.WriteLine("Вы Овен!");
            break;
        case 4:
            if (Chek(April, day) == 1)
            {
                Console.WriteLine("Вы Овен!");
            }
            else Console.WriteLine("Вы Телец!");
            break;
        case 5:
            if (Chek(May, day) == 1)
            {
                Console.WriteLine("Вы Телец!");
            }
            else Console.WriteLine("Вы Близнецы!");
            break;
        case 6:
            if (Chek(June,day) == 1)
            {
                Console.WriteLine("Вы Близнецы!");
            }
            else Console.WriteLine("Вы Рак!");
            break;
        case 7:
            if (Chek(July,day) == 1)
            {
                Console.WriteLine("Вы Рак!");
            }
            else Console.WriteLine("Вы Лев!");
            break;
        case 8:
            if (Chek(August,day) == 1)
            {
                Console.WriteLine("Вы Лев!");
            }
            else Console.WriteLine("Вы Дева!");
            break;
        case 9:
            if (Chek(September,day) == 1)
            {
                Console.WriteLine("Вы Дева!");
            }
            else Console.WriteLine("Вы Весы!");
            break;
        case 10:
            if (Chek(October,day) == 1)
            {
                Console.WriteLine("Вы Весы!");
            }
            else Console.WriteLine("Вы Скорпион!");
            break;
        case 11:
            if (Chek(November,day) == 1)
            {
                Console.WriteLine("Вы Скорпион!");
            }
            else Console.WriteLine("Вы Стрелец!");
            break;
        case 12:
            if (Chek(December,day) == 1)
            {
                Console.WriteLine("Вы Стрелец!");
            }
            else Console.WriteLine("Вы Козерог!");
            break;
    }
}
void theChinasZodiac(string[] arr)
{
    int year = Convert.ToInt32(arr[2]);

    int[] rat = { 1948, 1960, 1972, 1984, 1996, 2008, 2020 };
    int[] bull = { 1949, 1961, 1973, 1985, 1997, 2009, 2021 };
    int[] tiger = { 1950, 1962, 1974, 1986, 1998, 2010, 2022 };
    int[] rabbit = { 1951, 1963, 1975, 1987, 1999, 2011, 2023 };
    int[] dragon = { 1952, 1964, 1976, 1988, 2000, 2012, 2024 };
    int[] snail = { 1953, 1965, 1977, 1989, 2001, 2013, 2025 };
    int[] horse = { 1954, 1966, 1978, 1990, 2002, 2014, 2026 };
    int[] sheep = { 1955, 1967, 1979, 1991, 2003, 2015, 2027 };
    int[] monkey = { 1956, 1968, 1980, 1992, 2004, 2016, 2028 };
    int[] cock = { 1957, 1969, 1981, 1993, 2005, 2017, 2029 };
    int[] dog = { 1958, 1970, 1982, 1994, 2006, 2018, 2030 };
    int[] pig = { 1959, 19671, 1983, 1995, 2007, 2019, 2031 };

    int[] white = { 1950, 1951, 1960, 1961, 1970, 1971, 1980, 1981, 1990, 1991, 2000, 2001, 2010, 2011, 2020, 2021, 2030, 2031 };
    int[] blue = { 1952, 1953, 1962, 1963, 1972, 1973, 1982, 1983, 1992, 1993, 2002, 2003, 2012, 2013, 2022, 2023 };
    int[] green = { 1954, 1955, 1964, 1965, 1974, 1975, 1984, 1985, 1994, 1995, 2004, 2005, 2014, 2015, 2024, 2025 };
    int[] red = { 1956, 1957, 1966, 1967, 1976, 1977, 1986, 1987, 1996, 1997, 2006, 2007, 2016, 2017, 2026, 2027 };
    int[] yellow = { 1948, 1949, 1958, 1959, 1968, 1969, 1978, 1979, 1988, 1989, 1998, 1999, 2008, 2009, 2018, 2019, 2028, 2029 };

    string zodiacResponce = " ";
    string colorResponce = " ";

    int ChekZodiac(int[] arr, int year) 
    {
        foreach (int i in arr)
        {
            if (i == year) return 1;
        }
        return 0;
    }

    if (ChekZodiac(rat, year) == 1) zodiacResponce = "крысы";
    if (ChekZodiac(bull, year) == 1) zodiacResponce = "быка";
    if (ChekZodiac(tiger, year) == 1) zodiacResponce = "тигра";
    if (ChekZodiac(rabbit, year) == 1) zodiacResponce = "кролика";
    if (ChekZodiac(dragon, year) == 1) zodiacResponce = "дракона";
    if (ChekZodiac(snail, year) == 1) zodiacResponce = "змеи";
    if (ChekZodiac(horse, year) == 1) zodiacResponce = "лошади";
    if (ChekZodiac(sheep, year) == 1) zodiacResponce = "овцы";
    if (ChekZodiac(monkey, year) == 1) zodiacResponce = "обезьяны";
    if (ChekZodiac(cock, year) == 1) zodiacResponce = "петуха";
    if (ChekZodiac(dog, year) == 1) zodiacResponce = "собаки";
    if (ChekZodiac(pig, year) == 1) zodiacResponce = "свиньи";

    if (ChekZodiac(white, year) == 1) colorResponce = "белый";
    if (ChekZodiac(blue, year) == 1) colorResponce = "синий";
    if (ChekZodiac(green, year) == 1) colorResponce = "зелёный";
    if (ChekZodiac(red, year) == 1) colorResponce = "красный";
    if (ChekZodiac(yellow, year) == 1) colorResponce = "жёлтый";

    Console.WriteLine($"Вы родились в {colorResponce} год {zodiacResponce}!");
}

Console.Write("Введите дату рождения>>");
string[] answer = Console.ReadLine().Split(".");

zodiacSign(answer);
theChinasZodiac(answer);
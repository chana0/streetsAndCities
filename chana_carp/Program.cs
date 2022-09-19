using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace chana_carp
{
    class Program
    {
        static List<City> cities = new List<City>();
        static List<Street> streets = new List<Street>();
        static int i1 = 0, i2 = 0;
        public static void Start()
        {
            int inp = 0;
            Console.WriteLine("תפריט אפשריות");
            Console.WriteLine("ליצירת רשומת עיר הקש 1" +
                "ליצירת רשומת רחוב הקש 2" +
                "להצגת ערים הקש 3" +
                "להצגת רחובות לפי השייכות לעיר מסוימת הקש 4" +
                "לסיום וציאה הקש 5 ");
            inp =int.Parse( Console.ReadLine());
            while (inp != 1 && inp != 2 && inp != 3 && inp != 4 && inp!=5 )
            {
                Console.WriteLine("תפריט אפשריות");
                Console.WriteLine("ליצירת רשומת עיר הקש 1" +
                    "ליצירת רשומת רחוב הקש 2" +
                    "להצגת ערים הקש 3" +
                    "להצגת רחובות לפי השייכות לעיר מסוימת הקש 4" +
                    "לסיום וציאה הקש 5 ");
                inp = int.Parse(Console.ReadLine());
            }
            if (inp == 1)
            {
                f1();
            }
            else if (inp == 2)
            {
                f2();
            }
            else if (inp == 3)
            {
                f3();
            }
            else if (inp == 4)
            {
                f4();
            }
            else if (inp == 5)
            {
                 Environment.Exit(0);
            }
        }
        public static void f1()
        {
            string nameNewCity;
            Console.WriteLine("הכנס שם עיר");
            nameNewCity = Console.ReadLine();
            cities.Add(new City()
            {
                Name = nameNewCity,
                Id = i1,
                Display = i1
            });
            i1++;
            Start();
        }
        public static void f2()
        {
            string nameNewStreet;
            int idCity;
            Console.WriteLine("הכנס שם רחוב");
            nameNewStreet = Console.ReadLine();
            streets.Add(new Street()
            {
                Name = nameNewStreet,
                Id = i2,
                Display = i2
            });
            Console.WriteLine("הקש מספר מתאים עבור העיר אליה משתייך הרחוב ");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            idCity = int.Parse(Console.ReadLine());
            while(!(idCity<cities.Count&&idCity>=0))
            {
                Console.WriteLine("הקש מספר מתאים עבור העיר אליה משתייך הרחוב ");
                idCity = int.Parse(Console.ReadLine());
            }
            streets.LastOrDefault().CityID = cities[idCity];
            i2++;
            Start();
        }
        public static void f3()
        {
            for (int i = 0; i < cities.Count; i++)
            {
                foreach (var city in cities)
                {
                    if (city.Display == i)
                    {
                        Console.WriteLine(city.Name);
                    }
                }
            }
            Start();
        }
        public static void f4()
        {
            string city0;
            List<Street> streets0 = new List<Street>();
            int i = 0;
            Console.WriteLine("הקש שם עיר להצגה ");
            city0 = Console.ReadLine();
            foreach (var street in streets)
            {
                if (street.CityID.Name.Equals(city0))
                {
                    streets0.Add(street);
                }
            }
            for (i = 0; i < streets0.Count; i++)
            {
                foreach (var street in streets)
                {
                    if (street.Display == i)
                    {
                        Console.WriteLine(street.Name);
                    }
                }
            }
            Start();
        }
        static void Main(string[] args)
        {
            Start();
        }
    }
}

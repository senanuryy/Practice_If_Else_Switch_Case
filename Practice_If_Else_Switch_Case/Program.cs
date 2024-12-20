using System;

namespace Practice_If_Else_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If/Else");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Ruya Manavina Hos Geldiniz!");

            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Cilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Diger butun meyveler = 4 TL");

            Console.Write("\nHangi meyveyi satin almak istersiniz? (Elma/Armut/Cilek/Muz/Diger): ");
            string meyve = Console.ReadLine().ToLower();

            if (meyve == "elma")
            {
                Console.WriteLine("Sectiginiz meyvenin fiyati: 2 TL");
            }
            else if (meyve == "armut")
            {
                Console.WriteLine("Sectiginiz meyvenin fiyati: 3 TL");
            }
            else if (meyve == "cilek")
            {
                Console.WriteLine("Sectiginiz meyvenin fiyati: 2 TL");
            }
            else if (meyve == "muz")
            {
                Console.WriteLine("Sectiginiz meyvenin fiyati: 3 TL");
            }
            else
            {
                Console.WriteLine("Sectiginiz meyvenin fiyati: 4 TL");
            }
            Console.WriteLine("\n\nSwitch/Case");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Ruya Manavina Hos Geldiniz!");

            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Cilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Diger butun meyveler = 4 TL");

            Console.Write("Hangi meyveyi satin almak istersiniz? (Elma/Armut/Cilek/Muz/Diger: ");
            string meyve2 = Console.ReadLine().ToLower();

            switch (meyve2)
            {
                case "elma":
                    Console.WriteLine("Sectiginiz meyvenin fiyati: 2 TL");
                    break;
                case "armut":
                    Console.WriteLine("Sectiginiz meyvenin fiyati: 3 TL");
                    break;
                case "cilek":
                    Console.WriteLine("Sectiginiz meyvenin fiyati: 2 TL");
                    break;
                case "muz":
                    Console.WriteLine("Sectiginiz meyvenin fiyati: 3 TL");
                    break;
                default:
                    Console.WriteLine("Sectiginiz meyvenin fiyati: 4 TL");
                    break;

            }

            //Switch ile çözmek daha doğru.
            //Okunabilirlik: Switch yapısı, sabit seçenekler arasında daha düzenli ve okunabilir bir yapı sağlar.
            //Performans: Switch yapısı, derleyici tarafından optimize edildiği için sabit değerler arasında daha hızlı çalışır; if-else yapısı ise her koşulu sırasıyla kontrol eder. 
            
        }

    }

}
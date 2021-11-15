using System;
using System.Collections.Generic;
using DucksPattern;
using DucksPattern.Ducks;

namespace Ducks
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string duckID = string.Empty; // id уточки, выбираемый пользователем
            while (!(new List<string> { "1", "2", "3", "4" }).Contains(duckID))
            {
                Console.WriteLine("Выберите уточку:");
                Console.WriteLine("1 - Ложная");
                Console.WriteLine("2 - Селезень");
                Console.WriteLine("3 - Рыжая");
                Console.WriteLine("4 - Резиновая");
                Console.Write("Выбор (цифра): ");
                duckID = Console.ReadLine();
                Console.WriteLine();
            }

            Duck duck;
            switch (duckID)
            {
                case "1": // Ложная
                    duck = new DecoyDuck();
                    break;
                case "2": // Селезень
                    duck = new MallardDuck();
                    break;
                case "3": // Рыжая
                    duck = new RedheadDuck();
                    break;
                default: // Резиновая
                    duck = new RubberDuck();
                    break;
            }

            duck.Display(); // Информация об уточке
            duck.Dead(); // Убийство уточки

            Console.Write("\nПовторить? (1 - да): ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                Main();
            }
        }
    }
}

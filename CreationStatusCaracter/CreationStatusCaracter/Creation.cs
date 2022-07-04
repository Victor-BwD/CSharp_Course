using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationStatusCaracter
{
    internal class Creation
    {
        public void CreationCaracter()
        {
            Status status = new Status();

            Console.WriteLine("Let's make create your caracter in a RPG");
            Console.WriteLine("Your name: ");
            status.Name = Console.ReadLine();
            Console.WriteLine("Your class: ");
            status.Class = Console.ReadLine();

            Console.Write("Strong: ");
            status.Strong = int.Parse(Console.ReadLine());

            Console.Write("Dexterity: ");
            status.Dex = int.Parse(Console.ReadLine());

            Console.Write("Intelligence: ");
            status.Intelligence = int.Parse(Console.ReadLine());

            if (status.Intelligence <= 8)
            {
                Console.WriteLine("With this intelligence, you won't be able to read and communicate properly.");
                Console.WriteLine("Are you sure? YES/NO");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "YES" || string.IsNullOrEmpty(answer))
                {
                    Console.WriteLine("Your caracter is created!");
                }
                else
                {
                    do
                    {
                        Console.Write("Intelligence: ");
                        status.Intelligence = int.Parse(Console.ReadLine());

                    } while (status.Intelligence <= 8);
                }
            }

            Console.WriteLine("Now is time to roll your constitution... Press enter to roll the dice...");
            string pressEnter = Console.ReadLine();

            while (!string.IsNullOrEmpty(pressEnter))
            {
                Console.WriteLine("Now is time to roll your constitution... Press enter to roll the dice...");
                pressEnter = Console.ReadLine();
            }

            Random rnd = new Random();
            status.Constitution = rnd.Next(1, 20);
            Console.WriteLine("Your constitution is: {0}", status.Constitution);

            Console.WriteLine("Your caracter is created!");
        }
    }
}

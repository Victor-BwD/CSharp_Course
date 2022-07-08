using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationStatusCaracter
{
    internal class Creation
    {
        private int numberOfPoints;

        public void CreationCaracter()
        {
            numberOfPoints = 28;

            Status status = new Status();
            Points points = new Points();

            Console.WriteLine("Let's make create your caracter in a RPG");
            Console.WriteLine("Your name: ");
            status.Name = Console.ReadLine();
            Console.WriteLine("Your class: ");
            status.Class = Console.ReadLine();

            Console.WriteLine("Lets choose your atributtes...");
            Console.WriteLine("You have {0} points to distribute, choose wisely", numberOfPoints);
            Console.WriteLine("Choose a number between 4 and 17 for each one");
            Console.WriteLine("Remember, with 8 or less intelligence you won't be able to read and communicate properly.");

            
            
                

            while (status.Strong < 4 || status.Strong > 17)
            {
                Console.Write("Strong: ");
                status.Strong = int.Parse(Console.ReadLine());
                points.SpendPoint(status.Strong);

            }

            
            while (status.Dex < 4 || status.Dex > 17)
            {
                Console.Write("Dexterity: ");
                status.Dex = int.Parse(Console.ReadLine());
                points.SpendPoint(status.Dex);
            }

           
            while (status.Intelligence < 4 || status.Intelligence > 17)
            {
                Console.Write("Intelligence: ");
                status.Intelligence = int.Parse(Console.ReadLine());
                points.SpendPoint(status.Intelligence);
            }


            Console.WriteLine("Now is time to roll your constitution... Press enter to roll the dice...");
            string pressEnter = Console.ReadLine();

            while (!string.IsNullOrEmpty(pressEnter))
            {
                Console.WriteLine("Now is time to roll your constitution... Press enter to roll the dice...");
                pressEnter = Console.ReadLine();
            }

            Random rnd = new Random();
            status.Constitution = rnd.Next(4, 17);
            Console.WriteLine("Your constitution is: {0}", status.Constitution);

            Console.WriteLine("Your caracter is created!");
        }
    }
}

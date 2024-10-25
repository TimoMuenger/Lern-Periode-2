using System.ComponentModel.Design;

namespace Lern_Periode_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

                Random zufall = new Random();
                int zufallszahl = zufall.Next(1, 100);
               
                

                Console.WriteLine("Eraten sie eine Zahl zwischen 1 und 100");
               
                int guess = int.Parse(Console.ReadLine());
               
                if (guess > zufallszahl)
                {
                    Console.WriteLine("Die eingegebene Zahl ist zu gross");

                }
                
                else if (guess < zufallszahl) 
                {
                    Console.WriteLine("Die eingegebene Zahl ist zu klein");

                }
                else if (guess == zufallszahl)
                {
                    Console.WriteLine("Sie haben die Zahl erraten und gewonnen!");

                }


            while (guess != zufallszahl);

        
        }
            
    }

}

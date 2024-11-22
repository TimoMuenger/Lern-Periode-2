using System.Globalization;
using System.Net.WebSockets;

namespace VociTrainerEnglisch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tiere = { "Hund", "Katze", "Pferd", "Elefant", "Löwe", "Tiger", "Hase", "Fuchs", "Bär", "Giraffe" };
            string[] animals = { "Dog", "Cat", "Horse", "Elephant", "Lion", "Tiger", "Rabbit", "Fox", "Bear", "Giraffe" };
            String answerUser;

            Console.WriteLine("Willkommen zum Voci Trainer.");
            Console.WriteLine("Was heisst" tiere[0] "auf Englisch");
            answerUser = Console.ReadLine();
            if (answerUser == animals[0])
            {
                Console.WriteLine("Richtige Antwort!"); 
            }
            else
            {
                Console.WriteLine("Falsche Antwort");
            }
        }
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tiere = { "Hund", "Katze", "Pferd", "Elefant", "Löwe", "Tiger", "Hase", "Fuchs", "Bär", "Giraffe" };
            string[] animals = { "Dog", "Cat", "Horse", "Elephant", "Lion", "Tiger", "Rabbit", "Fox", "Bear", "Giraffe" };
            string[] animaux = { "Chien", "Chat", "Cheval", "Éléphant", "Lion", "Tigre", "Lièvre", "Renard", "Ours", "Girafe" };

            string LanguageUserAnswer;
            string AnimalUserAnswer;

            Console.WriteLine("Wollen sie Englisch oder Französisch lernen?");
            LanguageUserAnswer = Console.ReadLine();

            for (int i = 0; i < tiere.Length; i++)
            {




                if (LanguageUserAnswer == "Englisch")
                {
                    Console.WriteLine("Was heisst " + tiere[i] + " auf Englisch?");
                    AnimalUserAnswer = Console.ReadLine();
                    if (AnimalUserAnswer.ToLower() == animals[i].ToLower())
                    {
                        Console.WriteLine("Richtige Antwort!");
                    }
                    else
                    {
                        Console.WriteLine("Falsche Antwort!");

                    }

                }

                if (LanguageUserAnswer == "Französisch")
                {
                    Console.WriteLine("Was heisst " + tiere[i] + " auf Französisch?");
                    AnimalUserAnswer = Console.ReadLine();
                    if (AnimalUserAnswer.ToLower() == animaux[i].ToLower())
                    {
                        Console.WriteLine("Richtige Antwort!");
                    }
                    else
                    {
                        Console.WriteLine("Falsche Antwort!");
                    }
                }
            }
        }
    }
}


              

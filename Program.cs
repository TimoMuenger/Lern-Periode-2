using System.Runtime.InteropServices;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] field = { "x", "_", "_", "_", "_" };
            foreach(string f in field)
            {
                Console.Write(f);
            }

            
            Console.Clear();
            field[0] = "x";
            field[1] = "_";
            foreach (string f in field)
            {
                Console.Write(f);
            }
            Console.Clear();
            field[1] = "_";
            field[2] = "x";

        }
    
    }
}


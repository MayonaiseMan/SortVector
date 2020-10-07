using System;

namespace SortVector
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vs = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < vs.Length; i++)
                vs[i] = rnd.Next(1,101);

            

            for (int i = 0; i < vs.Length; i++)
                Console.WriteLine(vs[i]);

            Console.ReadKey();

            
        }

        
    }
}

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

            Ordina(vs);

            for (int i = 0; i < vs.Length; i++)
                Console.WriteLine(vs[i]);

            Console.ReadKey();

            
        }

        private static void Ordina(int[] vs)
        {
            for (int i = 0; i < vs.Length - 1; i++)
            {
                for (int j = 0; j < vs.Length - 1; j++)
                {
                    if (vs[j] > vs[j + 1])
                    {
                        int tmp = vs[j];
                        vs[j] = vs[j + 1];
                        vs[j + 1] = tmp;
                    }
                }
            }

        }




    }
}

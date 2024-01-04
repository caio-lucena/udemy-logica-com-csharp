using System;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vector = Console.ReadLine().Split(' ');

            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
            
            Console.WriteLine();
            
        }
    }
}

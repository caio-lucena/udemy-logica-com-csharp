using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome de 3 frutas separadas por espaço: ");
            string frutas = Console.ReadLine();
            string [] listaDeFrutas = frutas.Split(" ");

            for(int i = 0; i < listaDeFrutas.Length; i++)
            {
                Console.WriteLine("Item n° " + (1 + i) + ", " + listaDeFrutas[i]);
            }
            
        }
    }
}

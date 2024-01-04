// resolução do exercício proposto da aula 19

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo: ");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int numberOfRooms = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o preço de um produto: ");
            double productPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] vector = Console.ReadLine().Split(' ');

            Console.WriteLine(name);
            Console.WriteLine(numberOfRooms);
            Console.WriteLine(productPrice.ToString("F2", CultureInfo.InvariantCulture));
            
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }

        }
    }
}

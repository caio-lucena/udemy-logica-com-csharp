/*
resolução do exercício proposto da aula 20 (calcular a área de um terreno retangular,
assim como o seu preço dado o valor do metro quadrado).
*/

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double priceSquareMeter = double.Parse(Console.ReadLine());

            double totalArea = width * height;
            double totalPrice = totalArea * priceSquareMeter;

            Console.WriteLine("ÁREA = " + totalArea.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("PREÇO = " + totalPrice.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}

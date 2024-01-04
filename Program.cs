using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string name = Console.ReadLine(); 

            Console.Write("\nDigite sua idade: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("\nDigite sua altura: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + name + ", idade " + age + ", altura " + height.ToString("F1",CultureInfo.InvariantCulture));
            
        }
    }
}

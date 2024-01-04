using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Caio";
            byte age = 33;
            double height = 1.78;
            double salary = 6500.0;
            double bonus = 11350.57;
            double total = salary + bonus;

            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Dados do indivíduo: \n" + "Nome: " + name + "\nIdade: " + age + "\nAltura: " + height);
            Console.WriteLine("Total recebido no mês de dezembro: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}

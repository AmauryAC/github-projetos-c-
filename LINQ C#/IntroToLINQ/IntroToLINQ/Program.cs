using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ e expressões lambda
            // Cidades.Where(x => x.Nome == "Florianópolis")
            // Array -> filtrando dados com LINQ

            int[] numbers = new int[11] { 0, 9, 1, 2, 3, 4, 41, 15, 5, 6, 34 };

            // Números pares LINQ to SQL - filtro
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // LINQ com expressão lambda simplificado... mesmo resultado
            var numQuery2 = numbers.Where(x => x % 2 == 0).ToList();

            // Query execution
            Console.WriteLine("LINQ to SQL:");

            foreach(int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }

            Console.WriteLine("\nLINQ usando expressão lambda:");

            foreach (int num in numQuery2)
            {
                Console.Write("{0,1} ", num);
            }

            Console.ReadKey();
            Console.WriteLine();

            // Contando
            var total = numbers.Count(x => x > 4);

            // Ordenando
            var numerosOrdenados = numbers.OrderBy(x => x).ToList();

            Console.WriteLine("Qtde de números maiores que 4:");
            Console.Write("{0} ", total);

            Console.WriteLine("\nNúmeros ordenados:");

            foreach (int num in numerosOrdenados)
            {
                Console.Write("{0,1} ", num);
            }

            Console.ReadKey();
        }
    }
}

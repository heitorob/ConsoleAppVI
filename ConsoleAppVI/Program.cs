using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            string resp;

            do
            {
                Console.Write("Insira a descrição da despesa: ");
                string descricao = Console.ReadLine();

                Console.Write("Insira o valor da despesa: ");
                double valor = double.Parse(Console.ReadLine());

                total += valor;

                Console.Write("Deseja registrar outra despesa?\nS - Sim . N - Não : ");
                resp = Console.ReadLine().ToUpper().Substring(0,1);
            } while (resp == "S");

            Console.WriteLine("Valor total das despesas: " + total.ToString("C"));

            Console.Write("Insira o número de moradores na casa: ");
            int moradores = int.Parse(Console.ReadLine());

            double media = total / moradores;

            Console.Write("Cada morador deverá pagar: " + media.ToString("C"));

            Console.ReadKey();

            
        }
    }
}

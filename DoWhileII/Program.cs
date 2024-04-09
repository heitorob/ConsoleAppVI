using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0, total = 0;
            string resp, oprc;

            do
            {
                Console.Write("Insira a quantidade do produto: ");
                int qtde = int.Parse(Console.ReadLine());

                Console.Write("--\nInsira o valor unitário do produto: ");
                double unit = double.Parse(Console.ReadLine());

                valor = qtde * unit;

                Console.Write("--\nO produto será comprado ou devolvido?\nC - Compra . D - Devolução : ");
                oprc = Console.ReadLine().ToUpper().Substring(0, 1);

                switch (oprc)
                {
                    case "C":
                        total += valor;
                        break;

                    case "D":
                        total -= valor;
                        break;

                    default:
                        Console.WriteLine("\nCÓDIGO INVÁLIDO!! TENTE NOVAMENTE!!");
                        break;
                }

                Console.Write("\nDeseja registrar outro produto?\nS - Sim . N - Não : ");
                resp = Console.ReadLine().ToUpper().Substring(0, 1);

                Console.Clear();
            } while (resp == "S");

            if (total > 0)
            {
                Console.Write("Valor da conta: " + total.ToString("C") + " - A PAGAR");
            }
            else
            {
                Console.Write("Valor da conta: " + (total * -1).ToString("C") + " - A RECEBER");
            }

            Console.ReadKey();
        }
    }
}

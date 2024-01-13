using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace appMeta
{
    internal class Program
    {
        static void Main(string[] args)

            //programa que calcula o salario dos vendedores
            
        {
            Console.WriteLine("Qual o seu nome?");
            string nome= Console.ReadLine();
            Console.WriteLine("Qual seu Código de Vendas?");
            int cod= int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua meta?");
            int meta= int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto você já vendeu?");
            double venda= double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

            if (venda < meta) 
            {
                double salario = venda * 2.8 / 100;
                Console.WriteLine("nome: " + nome);
                Console.WriteLine("Cod de vendas: " + cod);
                Console.WriteLine("seu salario é:" + salario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("O seu Augusto está decepcionado com Você");
                Console.ReadLine();
            }
            else
            {
                double salario = venda * 3.3 / 100;
                Console.WriteLine("nome: " + nome);
                Console.WriteLine("Cod de vendas: " + cod);
                Console.WriteLine("seu salario é:" + salario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("O seu Augusto está muito feliz por você (mentira)");
                Console.ReadLine();

            }
        }
    }
}

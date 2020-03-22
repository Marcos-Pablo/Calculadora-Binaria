using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            string resultado = converterParaDecimal(num);

            Console.WriteLine(resultado);
            Console.ReadKey();
        }

        static string converterParaDecimal(int num)
        {
            string valor = "";
            if (num == 0 || num == 1)
                valor = Convert.ToString(num);
            else
            {
                while (num > 0)
                {
                    valor += Convert.ToString(num % 2);
                    num /= 2;
                }
            }

            return inverterString(valor);
        }

        static string inverterString(string texto)
        {
            string textoInvertido = "";
            for (int i = texto.Length - 1; i >= 0; i--)
            {
                textoInvertido += texto[i];
            }
            return textoInvertido;
        }
    }
}

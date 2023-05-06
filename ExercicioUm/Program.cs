using System;
using System.Globalization;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            #region[globalVariables]

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            #endregion
            Console.WriteLine("Digite a sua idade: ");
            //byte idade = byte.Parse(Console.ReadLine());

            bool resposta = false;

            while (resposta == false)
            {
                if (!byte.TryParse(Console.ReadLine(), out byte idade))               
                    Console.Write("Digita um número, idiota: ");                
                else                
                    Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
                    resposta = true;               
            }


            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é 1.", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é 1", produto2, preco2);
            Console.WriteLine("Medida com  oito casas decimais: {0}", medida);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}

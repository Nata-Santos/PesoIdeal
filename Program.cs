using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal altura, pesoI;
            string sexo;
            bool alturaCorreta;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("----Peso Ideal----");
            Console.ResetColor();
            Console.Write("\nDigite a sua altura em m.....:");
            alturaCorreta = decimal.TryParse(Console.ReadLine(), out altura);

            if (!alturaCorreta)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite a Altura correta.");
                Console.ResetColor();
                Environment.Exit(1);
            }


            Console.Write("Digite F para Feminino e M para Masculino...:");
            sexo = Console.ReadLine().ToUpper();

            if (sexo.Equals("M"))
            {
                pesoI = altura * 72.7m - 58;
                Console.WriteLine($"Seu peso ideal é {pesoI:N1} Kg");
            }
            else if (sexo.Equals("F"))
            {
                pesoI = altura * 62.1m - 44.7m;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite o Sexo corretamente.");
                Console.ResetColor();
            }

            
                
            

        }
    }
}

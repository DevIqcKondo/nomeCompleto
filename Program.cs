using System;

namespace nomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá usuário, qual o seu nome? ");
            Console.ForegroundColor=ConsoleColor.Yellow;
            string nome1 = Console.ReadLine();
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("E o seu sobrenome? ");
            Console.ForegroundColor=ConsoleColor.Yellow;
            string nome2 = Console.ReadLine();
            Console.ForegroundColor=ConsoleColor.White;
            Console.Write("Seu nome completo é: ");
            Console.ForegroundColor=ConsoleColor.Green;
            Console.Write(nome1);
            Console.Write(" ");
            Console.Write(nome2);
            Console.WriteLine();
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("Seu nome em formato catálogo ficaria assim:");
            Console.WriteLine("Pressione \"ENTER");
            Console.ForegroundColor=ConsoleColor.Red;
            Console.ReadKey();
            Console.Write(nome2.ToUpper());
            Console.Write(", ");
            Console.Write(nome1);
            Console.WriteLine();
            Console.ResetColor();


            
        }
    }
}

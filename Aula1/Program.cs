using System;

namespace Aula1
{
    internal class Program
    {
        public static decimal numero1 = 0;
        public static decimal numero2 = 0;
        public static decimal resultado = 0;

        static void Main(string[] args)
        {
            //declarar variavel
            decimal resultado = 0;
            Console.WriteLine("Seja bem vindo a calculadora!");
            Console.WriteLine("Vamos Somar");

            ReceberDoisNumeros();

            resultado = Somar(numero1, numero2);

            Console.WriteLine("Resultado: " + resultado);

            //Console.WriteLine("Qual opção: ");
            //var opcao = Console.ReadLine();

            //if (opcao == "1")
            //{
            //    Console.WriteLine("opcao 1");
            //}
            //else if (opcao == "2")
            //{
            //    Console.WriteLine("opcao 2");
            //}
            //else
            //{
            //    Console.WriteLine("Nenhuma");
            //}
        }

        public static void ReceberDoisNumeros()
        {
            numero1 = 0;
            numero2 = 0;

            Console.WriteLine("Digite o primeiro numero:");
            //como ler um texto(string) do console
            string escritoNoConsole = Console.ReadLine();

            numero1 = Convert.ToDecimal(escritoNoConsole);

            Console.WriteLine("Digite o segundo numero:");

            //como ler um texto(string) do console
            escritoNoConsole = Console.ReadLine();

            //converter string para decimal
            numero2 = Convert.ToInt32(escritoNoConsole);
        }

        public static decimal Somar(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
    }
}
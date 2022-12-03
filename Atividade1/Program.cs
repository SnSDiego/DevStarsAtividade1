using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Licao1
            Console.WriteLine("1 - Faça um programa para ler dois valores inteiros, e depois mostrar na tela a\n" +
                "soma desses números com uma mensagem explicativa, conforme exemplos.");

            Console.WriteLine("Insira o numero de A");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero de B");
            Console.WriteLine();
            int numero2 = int.Parse(Console.ReadLine());
            int soma = numero1 + numero2;
            Console.WriteLine("A soma é:" + soma);
            Console.WriteLine();

            #endregion

        }
    }
}

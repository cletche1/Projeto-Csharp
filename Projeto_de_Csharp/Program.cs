using System;

namespace Projeto_de_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Olá Mundo!");
            //Console.ReadKey();

            string nome = "Adalberto";
            int idade = 40;
            char genero = 'M';
            Console.WriteLine(nome +" tem "+ idade +" anos "+ " do sexo "+ genero);

            Console.WriteLine("Favor precione qualquer tecla para sair: ");

            Console.ReadLine();


        }
    }
}

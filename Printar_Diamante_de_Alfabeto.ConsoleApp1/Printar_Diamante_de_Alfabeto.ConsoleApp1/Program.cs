using System;
namespace ExercicioDiamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variaveis 
            
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


            //Converter o valor pra char   
            char[] arAlfabeto = alfabeto.ToCharArray();

            Console.WriteLine("Digite uma letra:");
             string letra = Console.ReadLine();

            int linhaArray = alfabeto.IndexOf(letra);
            int numero_de_espacos_esquerda = linhaArray;
            int numero_de_espacos_direita = 1;

            //Rodar o array 
            for (int i=0; i<linhaArray; i++)
            {
                //Printar espaços
                for (int k = numero_de_espacos_esquerda; k > 0;k--)
                {
                    Console.Write(" ");

                }

                numero_de_espacos_esquerda--;
                if (i == 0)
                {
                   
                }
               else
                {
                    Console.Write(arAlfabeto[i]);
                }

                for (int k = 0; k < numero_de_espacos_direita; k++)
                {
                    Console.Write(" ");
                    
                }
                numero_de_espacos_direita = numero_de_espacos_direita+2;

               
                    Console.Write(arAlfabeto[i]);
                

                Console.WriteLine("\n");

            }

            Console.ReadLine();

        }
    }
}

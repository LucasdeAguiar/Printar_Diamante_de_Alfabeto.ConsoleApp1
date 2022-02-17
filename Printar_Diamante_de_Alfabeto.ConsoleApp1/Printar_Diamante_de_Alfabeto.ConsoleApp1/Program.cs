using System;
namespace ExercicioDiamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region declaração de variáveis

            // Variaveis 

            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string teste123;

            //Converter o valor pra char   
            char[] arAlfabeto = alfabeto.ToCharArray();

            //Tratar para que o usuário possa digitar tanto com letra minúscula quanto com maiúscula
            string letra,letraMinuscula;

            #endregion

            #region ler a letra, realizar tratamento, iniciar array e números de espaços dos lados
            Console.WriteLine("Digite uma letra:");
             letraMinuscula = Console.ReadLine();
               
             letra = letraMinuscula.ToUpper();
           

            int linhaArray = alfabeto.IndexOf(letra);


            #endregion

            #region parte de cima do diamante

            //Declaração dos números de espaços
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

               //Decrementar espaços da esquerda
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

            #endregion

            #region parte de baixo do diamante

            for (int i = linhaArray; i >= 0; i--)
            {
                //Printar espaços
                for (int k = numero_de_espacos_esquerda; k > 0; k--)
                {
                    Console.Write(" ");

                }

                //Decrementar espaços da esquerda
                numero_de_espacos_esquerda++;

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
                numero_de_espacos_direita = numero_de_espacos_direita - 2;


                Console.Write(arAlfabeto[i]);


                Console.WriteLine("\n");

            }

            #endregion

            #region readline para o programa não fechar


            Console.ReadLine();
            #endregion

        }
    }
}

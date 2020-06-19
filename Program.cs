using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Para cada exercício abaixo crie um novo projeto com o template indicado, e o nome indicado.

           [console: Negativo] Leia um número inteiro e exiba a mensagem "Você digitou um número negativo." caso o número seja menor que zero.
           Ex.:
           Digite um número: -12
           Você digitou um número negativo.
           ou
           Digite um número: 12
           (nada a exibir)

           [console: Sinal] Leia um número inteiro e exiba "Negativo", "Zero" ou "Positivo", conforme o caso.
           Ex.:
           Digite um número: 35
           Positivo
           ou
           Digite um número: -10
           Negativo
           ou
           Digite um número: 0
           Zero
           */

            double  NumeroUsuario;

            Console.Write("Olá usuário, por favor digite um número...:");
            NumeroUsuario = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();

            // Utilizei o comando Convert.ToDouble para o número que o usúario digitar seja compreendidopelo sistema.

            if (NumeroUsuario >= 1)
            { 
                Console.WriteLine("O número escolhido é positivo.");
                
            }

            // Utilizei >= 1 para indicar ao sistema um número positivo.
            
            else if (NumeroUsuario <=-1)
            { 
                Console.WriteLine("O número escolhido é negativo");

            }

            // Utilizei  <=-1 para indicar ao sistema um número negativo.

            else if (NumeroUsuario == 0)
            { 
                Console.WriteLine("O número escolhido é igual a 0 ");
                
            }

            // Utilizei == 0 para indicar ao sistema um número igual a 0.

           
            Console.ReadKey();


            // Utilizei Console.ReadKey(); no final, pois segundo o professor Neri oferece uma melhor estrutura ao programa.
        }
    }
}

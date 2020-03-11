using System;

namespace ficha6
{
    public class Ficha6Solucao 
    {
        
    
            #region Exercicio11

            public static void Exercicio11()

            {

            string nome;

            int preco = 0, quantidade = 0, total = 0;


            Console.WriteLine("Digite o nome do produto: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o preço: ");
            preco = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            total = preco * quantidade;
            Console.WriteLine("Valor total da compra: " + total);

            Console.ReadLine();
            }


        #endregion

    }
}

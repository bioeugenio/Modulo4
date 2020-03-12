using System;

namespace Ficha7
{
    public class Ficha7Solucao
    {
        #region Exercicio1_1
        public static void Exercicio1_1()
        {
                        
            double nota;

            Console.WriteLine("Introduza a nota:\t");
            nota = double.Parse(Console.ReadLine());

            if(nota > 9.44)
            {
                Console.WriteLine("Passou");
            }
            else
            {
                Console.WriteLine("Chumbou");
            }

            Console.ReadKey();
        }
        #endregion

        #region Exercicio1_2

        public static void Exercicio1_2()
        {
            double altura, peso, bmi;

            Console.WriteLine("Introduzir a altura");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o peso");
            peso = double.Parse(Console.ReadLine());

            bmi = peso / ( altura * altura );

            if (bmi < 18.5)
            {
                Console.WriteLine("Abaixo peso");

            }
            else if ((bmi >= 18.5) && (bmi <= 24.9))
            {

                Console.WriteLine("Acima do peso");
            }
            else if ((bmi >= 25) && (bmi <= 29.9))
            {
                Console.WriteLine("Obeso");
            }

            Console.WriteLine(bmi);
            Console.ReadKey();

        }

        #endregion

        #region Exercicio1_3
        public static void Exercicio1_3()
        {
            int num;

            Console.WriteLine("Solicitar um numero");
            num = int.Parse(Console.ReadLine());

            if (num %3 == 0 && num % 7 == 0)
            {
                Console.WriteLine("É multiplo dos dois nuemro");
            } 
            else if (num %3 == 00)
            {
                Console.WriteLine("É multiplo de 3");
            }
            else if (num %7 == 00)
            {
                Console.WriteLine("É multiplo de 7");
            }
            else
            {
                Console.WriteLine("Não é multiplo dos dois");
            }
           


        }
        #endregion

        #region Exercicio1_4

        public static void Exerciocio1_4()
        {
            int num;

            Console.WriteLine("Introdução o numero");
            num = int.Parse(Console.ReadLine());

            if (num >= 30 && num <= 50)
            {
                Console.WriteLine("O numero encontra entre 30 e 50");
            }
            else 
            {
                Console.WriteLine("O numero não se encontra entre 30 e 50");
            }


        }

        #endregion

        #region Exercicio1_5

        public static void Exercicio1_5()
        {
            int num;

            Console.WriteLine("Introdução o numero");
            num = int.Parse(Console.ReadLine());

            if (num > 10 && num < 20)
            {
                Console.WriteLine("O numero encontra entre 10 e 20");
            }
            else
            {
                Console.WriteLine("O numero não se encontra entre 10 e 20");
            }
        }

        #endregion

        #region Exercicio1_6

        public static void Execicio1_6 ()
        {
            int num;

            Console.WriteLine("Escreve o piso");
            num = int.Parse(Console.ReadLine());

            if (num == 3 || num == 5)
            {
                Console.WriteLine("Piso avariado");
            }
            else if (num == -2 || num == -1 || num == 0 || num == 1|| num == 2 || num == 4 || num == 6)
            {
                Console.WriteLine("Piso esta disponivel");
            }
            else
            {
                Console.WriteLine("Piso não existe");
            }
            
        }


        #endregion

        #region Exercicio1_7

        public static void Exercicio1_7()
        {
            double num, resultado = 0;
                                

            for (double i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduza numero");
                num = double.Parse(Console.ReadLine());

                resultado += num;

                
                Console.WriteLine("Resultado da soma de dez numero =" + resultado);
            }
                       
            Console.ReadKey();
            
        }
        #endregion

        #region Exercicio1_8

        public static void Exercicio1_8()
        {
            string nome;
            double preço, quantidade, resuproduto, resutotal;


             

        }




        #endregion

        
    }
}

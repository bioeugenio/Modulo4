using System;

namespace ficha6
{
    public class Ficha6Solucao 
    {


        #region Exerciocio1_1

        public static void Exerciocio1_1()
        {
            string nome;

            Console.WriteLine("qual é o teu nome ?");
            nome = Console.ReadLine();

            Console.WriteLine("Olá " + nome);
            Console.ReadLine();

        }


        #endregion

        #region Exercicio1_2

        public static void Exerciocio1_2()
        {
            double num1, num2, resultado;

            Console.WriteLine("Introduza o primeiro numero ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o segundo numero");
            num2 = int.Parse(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("Resultado da soma " + resultado);

            Console.ReadKey();

        }

        #endregion

        #region Exerciocio1_3

        public static void Exercicio1_3()
        {
            double num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, resultado;

            Console.WriteLine("Introduza primeiro numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza segundo numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o terceiro numero");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o quarto numero");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o quinto numero");
            num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o sexto numero");
            num6 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o setimo numero");
            num7 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o oitavo numero");
            num8 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o nono numero");
            num9 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o decimo numero");
            num10 = int.Parse(Console.ReadLine());

            resultado = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;

            Console.WriteLine("Resultado da soma de dez numeros " + resultado);

            Console.ReadLine();
        }

        #endregion

        #region Exerciocio1_4

        public static void Exercicio1_4()
        {
            double num1, num2;

            Console.WriteLine("Introduza primeiro numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza segundo numero");
            num2 = int.Parse(Console.ReadLine());

            num1 = num2;

            num2 = num1;

            Console.WriteLine("num1 " + num2 + " num2 " + num1);
            Console.WriteLine("num2 " + num1 + " num1 " + num2);
            //Console.WriteLine(num1  == num2 && num2 == num1);
            Console.ReadLine();

        }

        #endregion

        #region Exercicio1_5_1

        public static void Exercicio1_51()
        {
            double num1, num2, num3, resultado;

            Console.WriteLine("Introduza o primeiro numero ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o segundo numero ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o terceiro numero");
            num3 = int.Parse(Console.ReadLine());

            resultado = -num1 + num2 + num3;

            Console.WriteLine("Resultado da opreção " + resultado);

            Console.ReadLine();
        }

        #endregion

        #region Exercicio1_5_2

        public static void Exercicio1_52()
        {
            double num1, num2, num3, resultado;

            Console.WriteLine("Introduza o primeiro numero ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o segundo numero ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o terceiro numero");
            num3 = int.Parse(Console.ReadLine());

            resultado = (num1 + num2) % num3;

            Console.WriteLine("Resultado da opreção " + resultado);

            Console.ReadLine();
        }


        #endregion

        #region Exercicio1_5_3

        public static void Exercicio1_53()
        {
            double num1, num2, num3, num4, resultado;

            Console.WriteLine("Introduza o primeiro numero ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o segundo numero ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o terceiro numero");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o terceiro numero");
            num4 = int.Parse(Console.ReadLine());

            resultado = num1 - num2 * num3 / num4;

            Console.WriteLine("Resultado da opreção " + resultado);

            Console.ReadLine();
        }


        #endregion

        #region Exercicio1_5_4

        public static void Exercicio1_54()
        {
            double num1, num2, num3, num4, num5, num6, resultado;

            Console.WriteLine("Introduza o primeiro numero ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o segundo numero ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o terceiro numero");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o terceiro numero");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o terceiro numero");
            num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o terceiro numero");
            num6 = int.Parse(Console.ReadLine());

            resultado = num1 + num2 / num3 * num4 - num5 % num6;

            Console.WriteLine("Resultado da opreção " + resultado);

            Console.ReadLine();
        }


        #endregion

        #region Exercicio1_6

        public static void Exercicio1_6()
        {
            double numero, resultado;

            Console.WriteLine("Digite um numero para construir uma tabuada: ");
            numero = int.Parse(Console.ReadLine());

            for (double i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                Console.WriteLine(resultado);

                Console.ReadLine();
            }

               
        }

        #endregion

        #region Exercicio1_7

        public static void Exercicio1_7()
        {
            double num1, num2, soma, media;

            Console.WriteLine("Digite primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;
            media = soma / 2;
            Console.WriteLine("Media: " + media);

            Console.ReadLine();
        }

        #endregion

        #region Exercicio1_8

        public static void Exercicio1_8()
        {
            double num1, num2, num3, num4, num5, soma, media;

            Console.WriteLine("Digite primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite primeiro número: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo número: ");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo número: ");
            num5 = int.Parse(Console.ReadLine());


            soma = num1 + num2 + num3 + num4 + num5;
            media = soma / 5;
            Console.WriteLine("Media: " + media);

            Console.ReadLine();
        }

        #endregion

        #region Exercicio1_9

        public static void Exercicio1_9()
        {
            double num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, soma, media;

            Console.WriteLine("Digite primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite primeiro número: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo número: ");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo número: ");
            num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite primeiro número: ");
            num6 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo número: ");
            num7 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite primeiro número: ");
            num8 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo número: ");
            num9 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo número: ");
            num10 = int.Parse(Console.ReadLine());

            soma = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
            media = soma / 10;
            Console.WriteLine("Media: " + media);

            Console.ReadLine();
        }

        #endregion

        #region Exercicio1_10

        public static void Exercicio1_10()
        {
            string nome = "";


            Console.WriteLine("Digite um caracter: ");
            nome = Console.ReadLine();


            Console.WriteLine(" " + nome + "  " + nome + "  " + nome);
            Console.WriteLine(" " + nome + "  " + nome + "  " + nome);
            Console.WriteLine(" " + nome + "  " + nome + "  " + nome);

            Console.ReadLine();
        }
        


        #endregion

        #region Exercicio1_11

        public static void Exercicio1_11()
        {

            string nome;
            double preco = 0, quantidade = 0;
            
            Console.WriteLine("Digite o nome do produto: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o preço: ");
            preco = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            double total = preco * quantidade;
            Console.WriteLine("Valor total da compra: " + total);

            Console.ReadLine();
        }


        #endregion

        #region Exercicio2_1

        public static void Exercicio2_1()
        {
            string nome;

            Console.WriteLine("Diz algo que eu não sabia ?");
            nome = Console.ReadLine();

            Console.WriteLine("Eu sabia " + nome + " ...daaa!!!");
            Console.ReadLine();
        }
        
        #endregion

        #region Exercicio2_2

        public static void Exercicio2_2()
        {
            Console.WriteLine("Digite o preço: ");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("O primeiro numeró é " + num1 + " e o segundo numero é " + num2);

            Console.ReadKey();
        }


        #endregion

        #region Exercicio2_3

        //public static void Exercicio2_3()
        //{
        //    double hora, minu, segu, 

        //    Console.WriteLine("Quantas horas: ");
        //    var hora = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Quantos minutos: ");
        //    var minu = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Quantos segundos: ");
        //    var segu = int.Parse(Console.ReadLine());


        //   Console.WriteLine("Horas " + num1 + " Minutos " + num2);

        //}


        #endregion

        #region Exercicio2_4

        #endregion

        #region Exercicio2_5

        #endregion

        #region Exercicio3_1

        #endregion

        #region Exercicio3_2

        #endregion




    }
}

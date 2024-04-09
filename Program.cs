using System;

namespace TrianguloOrientado.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulos NovoTriangulo = new Triangulos();
            NovoTriangulo.lado_1 = 5;
            NovoTriangulo.lado_2 = 5;
            NovoTriangulo.lado_3 = 3;
            NovoTriangulo.analisatriangulo();

            Triangulos Segundo = new Triangulos();
            Segundo.lado_1 = 5; Segundo.lado_2 = 5; Segundo.lado_3 = 5;
            Segundo.analisatriangulo();

            Triangulos Terceiro = new Triangulos();
            Terceiro.lado_1 = 5; Terceiro.lado_2 = 6; Terceiro.lado_3 = 4;
            Terceiro.analisatriangulo();

            Console.ReadLine();


        }
        #region codigo sequencial
        //Console.WriteLine("Informe o primeiro lado do triângulo: ");
        //string lado_a = Console.ReadLine();
        //int lado_1 = Convert.ToInt32(int.Parse(lado_a));

        //Console.WriteLine("Informe o segundo lado do triângulo: ");
        //string lado_b = Console.ReadLine();
        //int lado_2 = Convert.ToInt32(int.Parse(lado_b));

        //Console.WriteLine("Informe o terceiro lado do triângulo: ");
        //string lado_c = Console.ReadLine();
        //int lado_3 = Convert.ToInt32(int.Parse(lado_c));


        //if (lado_1 != lado_2 && lado_2 != lado_3)
        //{

        //    Console.WriteLine("\nEste triângulo é Escaleno\n");

        //}

        //else if (lado_1 == lado_2 && lado_2 != lado_3 || lado_2 == lado_3 && lado_3 != lado_1 || lado_3 == lado_1 && lado_3 != lado_1)

        //{
        //    Console.WriteLine("\nEste triângulo é Isoceles\n");


        //}
        //else

        //{

        //    Console.WriteLine("\nEste é um triângulo Equilátero\n");


        //}
        //Console.ReadLine();
        #endregion



        public class Triangulos
        {
            public double lado_1;

            public double lado_2;

            public double lado_3;

            public void analisatriangulo()
            {
                if ((lado_1 + lado_2) > lado_3 || (lado_2 + lado_3) > lado_1 || (lado_3 + lado_1) > lado_2)
                {

                    if (lado_1 != lado_2 && lado_2 != lado_3)
                    {

                        Console.WriteLine("\nEste triângulo é Escaleno\n");

                    }

                    else if (lado_1 == lado_2 && lado_2 != lado_3 || lado_2 == lado_3 && lado_3 != lado_1 || lado_3 == lado_1 && lado_3 != lado_1)

                    {
                        Console.WriteLine("\nEste triângulo é Isoceles\n");


                    }
                    else

                    {

                        Console.WriteLine("\nEste é um triângulo Equilátero\n");


                    }
                }
                Console.ReadLine();


            }
        }
    }
}






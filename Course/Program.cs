using System;
using System.Collections.Generic;
using Course.Entities;
using System.Globalization;

// Teste fork

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static double Soma(double x, double y)
        {
            return x + y;
        }

        public static double Multiplicacao(double x, double y)
        {
            return x * y;
        }

        public static double Divisao(double x, double y)
        {
            return x / y;
        }

        public static double Subtracao(double x, double y)
        {
            return x - y;
        }

        public static double PotenciaQuadrado(double x)
        {
            return Math.Pow(x, 2);
        }

        public static double PotenciaCubo(double x)
        {
            return Math.Pow(x, 3);
        }

        public static double Raiz(double x)
        {
            return Math.Sqrt(x);
        }

        public static void Menu()
        {
            int opcao = 1;

            while (opcao != 9)
            {
                Console.WriteLine("\n---- CALCULADORA ----");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtracao");
                Console.WriteLine("3 - Multiplicacao");
                Console.WriteLine("4 - Divisao");
                Console.WriteLine("5 - Potencia ao quadrado");
                Console.WriteLine("6 - Potencia ao cubo");
                Console.WriteLine("7 - Raiz");
                Console.WriteLine("8 - Limpar tela");
                Console.WriteLine("9 - Fim");
                Console.Write("Digite sua opcao: ");
                opcao = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (opcao == 1)
                {
                    Console.Write("Digite o 1 numero: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("Digite o 2 numero: ");
                    double y = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nResultado: " + Soma(x, y));
                }
                else if (opcao == 2)
                {
                    Console.Write("Digite o 1 numero: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("Digite o 2 numero: ");
                    double y = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("\nResultado: " + Subtracao(x, y));
                }
                else if (opcao == 3)
                {
                    Console.Write("Digite o 1 numero: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("Digite o 2 numero: ");
                    double y = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("\nResultado: " + Multiplicacao(x, y));
                }
                else if (opcao == 4)
                {
                    Console.Write("Digite o 1 numero: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("Digite o 2 numero: ");
                    double y = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("\nResultado: " + Divisao(x, y));
                }
                else if (opcao == 5)
                {
                    Console.Write("Digite um numero: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("\nResultado: " + PotenciaQuadrado(x));
                }
                else if (opcao == 6)
                {
                    Console.Write("Digite um numero: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("\nResultado: " + PotenciaCubo(x));
                }
                else if (opcao == 7)
                {
                    Console.Write("Digite um numero: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("\nResultado: " + Raiz(x));
                }
                else if (opcao == 8)
                {
                    Console.Clear();
                }
                else if (opcao == 9)
                {
                    Console.WriteLine("\nCalculadora encerrada.");
                }
            }
        }
    }
}

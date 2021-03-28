using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A, B, e C com espaço entre eles: ");
            String valores = Console.ReadLine();
            String[] x = valores.Split(' ');

            double delta = Math.Pow(double.Parse(x[1]), 2) - 4 * double.Parse(x[0]) * double.Parse(x[2]);

            Console.WriteLine();

            Console.WriteLine("Delta = " + delta);
            Console.WriteLine();

            if (delta > 0)
            {
                double x1 = (double.Parse(x[1]) * -1 + Math.Sqrt(delta)) / (2 * double.Parse(x[0]));

                if (x1 % 1 != 0)
                {
                    double parte1 = (double.Parse(x[1]) * -1 + Math.Sqrt(delta));
                    double parte2 = (2 * double.Parse(x[0]));
                    if (parte1 < 0)
                    {
                        int cont = 0;
                        for (int i = 1; i <= parte1 * -1; i++)
                        {
                            if (parte1 % i == 0 && parte2 % i == 0)
                            {
                                cont = i;
                            }
                        }
                        Console.Write($" x1 = {parte1 / cont}/{parte2 / cont}");
                    }
                    else
                    {
                        int cont = 0;
                        for (int i = 2; i <= parte1; i++)
                        {
                            if (parte1 % i == 0 && parte2 % i == 0)
                            {
                                cont = i;
                            }
                        }
                        Console.Write($"x1 = {parte1 / cont}/{parte2 / cont}");
                    }
                }
                else
                {
                    Console.WriteLine("x1 = " + x1);
                }

                Console.WriteLine();

                double x2 = (double.Parse(x[1]) * -1 - Math.Sqrt(delta)) / (2 * double.Parse(x[0]));

                if (x2 % 1 != 0)
                {
                    double parte1 = (double.Parse(x[1]) * -1 - Math.Sqrt(delta));
                    double parte2 = (2 * double.Parse(x[0]));
                    if (parte1 < 0)
                    {
                        int cont = 0;
                        for (int i = 1; i <= parte1 * -1; i++)
                        {
                            if (parte1 % i == 0 && parte2 % i == 0)
                            {
                                cont = i;
                            }
                        }
                        Console.Write($"x2 = {parte1 / cont}/{parte2 / cont}");
                    }
                    else
                    {
                        int cont = 0;
                        for (int i = 2; i <= parte1; i++)
                        {
                            if (parte1 % i == 0 && parte2 % i == 0)
                            {
                                cont = i;
                            }
                        }
                        Console.Write($"x2 = {parte1 / cont}/{parte2 / cont}");
                    }
                }
                else
                {
                    Console.WriteLine("x2 = " + x2);
                }
            }
            else
            {
                if (delta == 0)
                {
                    double x1 = (double.Parse(x[1]) * -1 + Math.Sqrt(delta)) / (2 * double.Parse(x[0]));

                    if (x1 % 1 != 0)
                    {
                        double parte1 = (double.Parse(x[1]) * -1 + Math.Sqrt(delta));
                        double parte2 = (2 * double.Parse(x[0]));
                        if (parte1 < 0)
                        {
                            int cont = 0;
                            for (int i = 1; i <= parte1 * -1; i++)
                            {
                                if (parte1 % i == 0 && parte2 % i == 0)
                                {
                                    cont = i;
                                }
                            }
                            Console.Write($"x =  {parte1 / cont}/{parte2 / cont}");
                        }
                        else
                        {
                            int cont = 0;
                            for (int i = 2; i <= parte1; i++)
                            {
                                if (parte1 % i == 0 && parte2 % i == 0)
                                {
                                    cont = i;
                                }
                            }
                            Console.Write($"x =  {parte1 / cont}/{parte2 / cont}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("x = " + x1);
                    }
                }

                else
                {
                    Console.WriteLine("A Função nao tem raizes reais");
                }
            }


            Console.ReadKey();
        }
    }
}

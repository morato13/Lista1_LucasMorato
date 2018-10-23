using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDia28_LucasMorato
{
    class Program
    {
        static void Main(string[] args)
        {
                //Questão 01
                Console.Write("\nQuestão 01\n\n");
                int a;
                a = 1;
                while (a <= 40)
                {
                    Console.Write(a);
                    Console.Write("\t");
                    a = a + 1;
                }
                Console.Write("\n\n\nAperte enter para a proxima questão");
                Console.ReadKey();
                Console.Clear();

                // Questão 02
                Console.Write("\nQuestão 02\n\n");
                int x;
                int y;
                x = 2;
                y = 3;

                {
                    Console.WriteLine("x =" + x);
                    Console.WriteLine("o valor de x + x é " + (x + x));
                    Console.WriteLine("x = ");
                    Console.WriteLine((x + y) + " = " + (y + x));

                }
                Console.Write("\n\n\nAperte enter para a proxima questão");
                Console.ReadKey();
                Console.Clear();

                //Questão 03
                Console.Write("\nQuestão 02\n\n");

                {
                    Console.WriteLine("*\n**\n***\n****\n*****");

                }
                Console.Write("\n\n\nAperte enter para a proxima questão");
                Console.ReadKey();
                Console.Clear();

                //Questão 04
                Console.Write("\nQuestão 04\n\n");

                {
                    Console.Write("*");
                    Console.Write("***");
                    Console.WriteLine("*****");
                    Console.Write("****");
                    Console.WriteLine("**");

                }
                Console.Write("\n\n\nAperte enter para a proxima questão");
                Console.ReadKey();
                Console.Clear();

                //Questão 05
                Console.Write("\nQuestão 05\n\n");

                {
                    Console.WriteLine("Digite seu nome");
                    var nome = Console.ReadLine();

                    Console.WriteLine("Digite seu sobrenome");
                    var sobrenome = Console.ReadLine();

                    Console.WriteLine("Digite sua matrícula");
                    var matricula = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($" {matricula}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($" {nome} {sobrenome}");

                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.Write("\n\n\nAperte enter para a proxima questão");
                Console.ReadKey();
                Console.Clear();

                //Questão 06
                Console.Write("\nQuestão 06\n\n");

                {
                    Console.WriteLine("Digite um número");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite outro número");
                    int num2 = int.Parse(Console.ReadLine());

                    int resultado = 0;
                    resultado = num1 + num2;
                    Console.Write("\n Soma: {0}\n", resultado);
                    resultado = 0;
                    resultado = num1 - num2;
                    Console.Write(" Subtração: {0}\n", resultado);
                    resultado = 0;
                    resultado = num1 * num2;
                    Console.Write(" Multiplicação: {0}\n", resultado);
                    resultado = 0;
                    resultado = num1 / num2;
                    Console.Write(" Divisão: {0}", resultado);
                    resultado = 0;


                }
                Console.Write("\n\n\nAperte enter para a proxima questão");
                Console.ReadKey();
                Console.Clear();


                //Questão 07
                Console.Write("\nQuestão 07\n\n");

                {
                    Console.WriteLine("Digite o raio do círculo");
                    int raio1 = int.Parse(Console.ReadLine());

                    int diametro;
                    double circunferencia, area;
                    diametro = raio1 * 2;
                    Console.Write("\n Diâmetro: {0}\n", diametro);
                    circunferencia = raio1 * 2 * 3.14;
                    Console.Write("\n Circunferência: {0}\n", circunferencia);
                    area = 3.14 * raio1 * raio1;
                    Console.Write("\n Área: {0}\n", area);


                }
                Console.Write("\n\n\nAperte enter para a proxima questão");
                Console.ReadKey();
                Console.Clear();

                //Questão 08
                Console.Write("\nQuestão 08\n\n");

                {
                    Console.WriteLine("Digite o primeiro número");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número");
                    int num2 = int.Parse(Console.ReadLine());

                    if (num1 % num2 == 0)
                    {
                        Console.Write("\nO número {0} é múltiplo de {1}", num1, num2);
                    }
                    else
                    {
                        Console.Write("\nO número {0} não é múltiplo de {1}", num1, num2);
                    }



                }
                Console.Write("\n\n\nAperte enter para a proxima questão");
                Console.ReadKey();
                Console.Clear();


                //Questão 09
                Console.Write("\nQuestão 09\n\n");

                {
                    int aux;

                    Console.WriteLine("Digite um número de 5 dígitos ");
                    int num = int.Parse(Console.ReadLine());

                    aux = num / 10000;
                    Console.Write(aux + "   ");

                    aux = num / 1000;
                    aux = aux % 10;
                    Console.Write(aux + "   ");

                    aux = num / 100;
                    aux = aux % 10;
                    Console.Write(aux + "   ");

                    aux = num / 10;
                    aux = aux % 10;
                    Console.Write(aux + "   ");

                    aux = num % 10;
                    Console.Write(aux + "   ");
                }

                Console.Write("\n\n\nAperte enter para a proxima questão");
                Console.ReadKey();
                Console.Clear();



                //Questão 10

                {
                    Console.Write("Número\t\tQuadrado\tCubo\n");


                    int num;
                    num = 1;
                    while (num <= 10)
                    {
                        Console.Write(num + "\t\t");
                        Console.Write(num * num + "\t\t");
                        Console.Write(num * num * num + "\n");
                        num++;
                    }

                    Console.Write("\n\n\nAperte enter para a proxima questão");
                    Console.ReadKey();
                    Console.Clear();
                
            }
        }
    }
}

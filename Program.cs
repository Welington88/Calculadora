using System;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                Calculo c = new Calculo();
                Console.WriteLine($"Chamei o método Delegate { nameof(c.receberNumero)}...", ConsoleColor.Yellow);
                for (int i = 1; i <= 4; i++)
                {
                    var n1 = await c.receberNumero();
                    var n2 = await c.receberNumero();
                    switch (i)
                    {
                        case 1:
                            var sum = new Calculate(Sum);
                            var resultSum = sum(n1, n2);
                            Console.WriteLine($"A soma entre {n1} + {n2} = {resultSum}");
                            break;
                        case 2:
                            var mult = new Calculate(Mult);
                            var resultMult = mult(n1, n2);
                            Console.WriteLine($"A Multiplicação entre {n1} * {n2} = {resultMult}");
                            break;
                        case 3:
                            var sub = new Calculate(Sub);
                            var resultSub = sub(n1, n2);
                            Console.WriteLine($"A Subtração entre {n1} - {n2} = {resultSub}");
                            break;
                        case 4:
                            try
                            {
                                var divide = new Calculate(Divide);
                                var resultDivide = divide(n1, n2);
                                Console.WriteLine($"A Divide entre {n1} / {n2} = {resultDivide}", n1, n2, resultDivide);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"A Divide entre" + ex);
                            }
                            break;
                    }
                }
                //throw new Exception("Erro")
                Console.WriteLine("--------------------------------------------------", ConsoleColor.Green);
                Console.WriteLine("Terminei o Trabalho", ConsoleColor.Red);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        //----------------------------------Metodos----------------------------------------------------------
        public static double Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public static double Mult(int n1, int n2)
        {
            return n1 * n2;
        }

        public static double Sub(int n1, int n2)
        {
            return n1 - n2;
        }

        public static double Divide(int n1, int n2)
        {
            float divide = ( float.Parse(n1.ToString()) / float.Parse(n2.ToString()));
            return double.Parse(divide.ToString());
        }
    }
    //delegate
    delegate double Calculate(int x, int y);
}

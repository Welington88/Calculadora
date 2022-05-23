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
                Console.WriteLine($"Chamei o método { nameof(c.imprimirNumeros)}...", ConsoleColor.Yellow);
                c.imprimirNumeros();
                //assicrono
                //throw new Exception("Erro");
                Console.WriteLine("Pronto, Tudo deu certo! \nQuando eu terminar te aviso...", ConsoleColor.Green);
                Console.WriteLine("--------------------------------------------------", ConsoleColor.Green);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

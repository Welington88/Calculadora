using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculo
    {
        public Calculo()
        {
        }

        public Task<List<int>> listaNumeros()
        {
            var random = new Random(); // numeros aleatorios
            var list = Enumerable.Range(0, 100).Select(number => random.Next(0, 100)).ToList();
            return Task.Run(() => list);
        }

        public async void imprimirNumeros()
        {
            var list = await listaNumeros();
            var listaFinal = list.Where(list => list <= 10).OrderBy(list => list).Distinct();
            Thread.Sleep(5000);
            foreach (var l in listaFinal)
            {
                Console.WriteLine(l.ToString(), ConsoleColor.Blue);
            }
            Console.WriteLine("--------------------------------------------------", ConsoleColor.Green);
            Console.WriteLine("Terminei o Trabalho", ConsoleColor.Red);
        }
    }
}
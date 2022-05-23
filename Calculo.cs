using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<int> receberNumero()
        {
            var list = await listaNumeros();
            var resultado = list.Where(list => list <= 10).OrderBy(list => list).Distinct().Sum();
            //Thread.Sleep(5000);
            return resultado;
        }
    }
}
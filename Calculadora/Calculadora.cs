using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCalculadora
{
    class Calculadora
    {
        private List<double> numeros = new List<double>();

        public void addItem(double item)
        {
            this.numeros.Add(item);
        }

        public double somar()
        {
            double resultado = 0;
            foreach(double numero in this.numeros)
            {
                resultado += numero;
            }
            this.numeros.Clear();
            return resultado;
        }

    }
}

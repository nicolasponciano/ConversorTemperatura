using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedaQA
{
    public class Temperatura
    {
        public string Valor { get; set; }

        public string unidade { get; set; }

        public double temperaturaFahrenheit = 32;

        public string converteCelsius()
        {
         float resultado = (float)(float.Parse(unidade) * (temperaturaFahrenheit - 32) * 5 / 9);
            return resultado.ToString();
        }

        public string converteFahrenheit()
        {
         float resultado = (float.Parse(unidade) * 9 / 5 + 32);
            return resultado.ToString();
        }
        public string converteKelvin()
        {
         float resultado = (float.Parse(unidade) + 273.15f);
            return resultado.ToString();
        }
    }
}


            

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedaQA
{
    public class Temperatura
    {
        public double Celsius(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public double Fahrenheit(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public double Kelvin(double celsius)
        {
            return celsius + 273.15;
        }
    }
}




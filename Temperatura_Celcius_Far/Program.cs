using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_Celcius_Far
{
    class Program
    {
        static void Main(string[] args)
        {
            //Covertir de grados celsius a faren

            double celsius, fahrenheit;

            Console.WriteLine("Digite la temperatura Celsius a Convertir en Fahrenheit");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius=  90  * 9 / 5) + 32;
            fahrenheit = Convert.ToInt32(fahrenheit);

            Console.WriteLine("El equivalente a fahrenheit es:  " + fahrenheit);

            Console.ReadKey();
        }
    }
}

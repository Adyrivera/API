using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

    namespace Calculadora_consola
    {
        class Program
        {
            static void Main(string[] args)
            {
                int x;
                int y;
                string operacion;
                string caracter;
                Console.WriteLine("teclee el primer valor");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("teclee el segundo valor");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("que operacion quiere realizar");
                caracter = Convert.ToString(Console.ReadLine());
                switch (caracter)
                {
                 case "+":
                    operacion = "x + y";
                    Console.WriteLine("el resultado de la suma es igual a" + operacion, Console.ForegroundColor = ConsoleColor.Green);
                    break;
                 case "-":
                    operacion = "x - y";
                    Console.WriteLine("el resultado de la suma es igual a" + operacion, Console.ForegroundColor = ConsoleColor.Yellow);
                    break;
                 case "*":
                    operacion = "x * y";
                    Console.WriteLine("el resultado de la suma es igual a" + operacion, Console.ForegroundColor = ConsoleColor.Red);
                    break;
                 case "/":
                    operacion = "x / y";
                    Console.WriteLine("el resultado de la suma es igual a" + operacion, Console.ForegroundColor=ConsoleColor.Blue);
                    break;
                }
                Console.ReadKey();
        }
    }
}


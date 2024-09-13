using System;

namespace hola_mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite su nombre");
            string nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("digite el primer digito");
            double num1 = Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("digite el segundo digito");
            double num2 = Convert.ToDouble( Console.ReadLine());

            double resultado;

            resultado = (num1 + num2);

            Console.WriteLine("su resultado es : + resultado ");
            Console.ReadKey();



            




        }
    }
}

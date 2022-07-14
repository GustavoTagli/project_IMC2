using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar o cálculo do IMC

            float imc, peso, altura;

            Console.WriteLine("Qual o seu peso?");
            //      cast
            peso = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a sua altura?");
            //        cast
            altura = (float) Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5) Console.WriteLine("\nAbaixo do peso!");
            else if (imc >= 18.5 && imc <= 24.9) Console.WriteLine("\nNormal");
            else if (imc >= 25 && imc <= 29.9) Console.WriteLine("\nSobrepeso!");
            else if (imc >= 30 && imc <= 39.9) Console.WriteLine("\nObesidade!");
            else Console.WriteLine("\nObesidade Grave!");
        }
    }
}

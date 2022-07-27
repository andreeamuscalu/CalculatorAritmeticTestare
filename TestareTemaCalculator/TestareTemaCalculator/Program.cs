using System;

namespace TestareTemaCalculator
{
    public class Program
    {
        const string lineDisplay = "------------------------------";
        const string invalidInput = "Ati introdus un input invalid";
        const string quitSentence = "Pentru a iesi din program, apasati 'q', altfel apasati orice tasta";
        const string exceptionDivisionByZero = "Impartirea la 0 nu se poate";

        static void Main(string[] args)
        {
            string firstNumber, secondNumber;
            bool exit = false;
            while (!exit)
            {
                ValidareInputuri(out firstNumber, out secondNumber);
                AfisareRezultate(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber));
                Console.WriteLine(quitSentence);
                if (Console.ReadLine() == "q")
                    exit = true;
            }
        }
        public static double Suma(double a, double b)
        {
            double sum = a + b;
            return sum;
        }
        public static double Diferenta(double a, double b)
        {
            double dif = a - b;
            return dif;
        }
        public static double Inmultire(double a, double b)
        {
            double inmult = a * b;
            return inmult;
        }
        public static string Impartire(double a, double b)
        {
            double impart = a / b;
            if (double.IsInfinity(impart))
            {
                return exceptionDivisionByZero;
            }
            else
                return impart.ToString();
        }
        public static void ValidareInputuri(out string firstnumber, out string secondNumber)
        {
            double num = -1;

        citireValoare1:
            Console.Write("Primul numar: ");
            string first = Console.ReadLine();

            if (double.TryParse(first, out num))
            {
            citireValoare2:
                Console.Write("Al doilea numar: ");
                string second = Console.ReadLine();

                if (double.TryParse(second, out num))
                {
                    firstnumber = first;
                    secondNumber = second;
                }
                else 
                {
                    Console.WriteLine(invalidInput);
                    goto citireValoare2;
                }
            }
            else
            {
                Console.WriteLine(invalidInput);
                goto citireValoare1;
            }
        }
        public static void AfisareRezultate(double a, double b)
        {
            Console.WriteLine(lineDisplay);
            Console.WriteLine("Suma: {0}", Suma(a, b));
            Console.WriteLine("Diferenta: {0}", Diferenta(a, b));
            Console.WriteLine("Inmultirea: {0}", Inmultire(a, b));
            Console.WriteLine("Impartirea: {0}", Impartire(a, b));
            Console.WriteLine(lineDisplay);
        }
    }
}

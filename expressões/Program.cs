using System;

namespace expressões
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Expressões numericas

            //Variaveis 

            double primeira, segunda, terceira;

            //1

            primeira = 80 - 6 * 7 + 5;

            //2

            segunda = +80 + (-60 + -100);

            //3

            terceira = 4 + (12 - (2 + 5) + 9);

            Console.WriteLine("Resposta da primeira é = " + primeira);
            Console.WriteLine("Resposta da segunda é = " + segunda);
            Console.WriteLine("Resposta da terceira é = " + terceira);

        }
    }
}
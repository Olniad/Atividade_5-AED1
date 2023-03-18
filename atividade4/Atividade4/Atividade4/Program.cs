using Classenumeros;
using System;
using System.Globalization;

namespace Exercicio4{
    internal class program
    {
        static void Main(string[] args)
        {
            Classe a, b, c;
            a = new Classe();
            b = new Classe();
            c = new Classe();

            a.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (a.A < 0)
            {
                Console.WriteLine("O numero é negativo, digite um novo valor");
                a.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            b.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (b.B < 0)
            {
                Console.WriteLine("O numero é negativo, digite um novo valor");
                b.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            c.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (c.C < 0)
            {
                Console.WriteLine("O numero é negativo, digite um novo valor");
                c.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double caso1 = a.A + b.B;
            double caso2 = a.A * a.A;
            double caso3 = b.B + b.B;
            double caso4 = c.B * c.B;
            double caso5 = caso3 + caso4;
            if(a.A >= caso1)
            {
                Console.WriteLine("Não forma triangulo");
            } else if (caso2 == caso5)
            {
                Console.WriteLine("Triangulo retangulo");
            }else if(caso2 > caso5)
            {
                Console.WriteLine("Triangulo obtusangulo");
            }else if(caso2 < caso5)
            {
                Console.WriteLine("Triangulo acutangulo");
            }
            else if(a.A == b.B || a.A == c.C || b.B == c.C )
            {
                Console.WriteLine("~triangulo isosceles");
            }










        }
    }
}

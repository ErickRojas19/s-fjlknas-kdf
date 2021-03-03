using System;

namespace Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo cir1 = new Circulo(5);
            Console.WriteLine(cir1);
            Circulo cir2 = new Circulo(7);
            Console.WriteLine(cir2);
            
            Triangulo tria1 = new Triangulo (4, 5, 8, 2, 9);
            Console.WriteLine(tria1);
            
            Rectangulo rec1 = new Rectangulo(10,4);
            Console.WriteLine(rec1);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    class Triangulo : FigurasGeometricas//Herencia
    {
        int basee;
        int altura;
        int lado1;
        int lado2;
        int lado3;

        public int Basee { get => basee; set => basee = value; }
        public int Altura { get => altura; set => altura = value; }
        public int Lado1 { get => lado1; set => lado1 = value; }
        public int Lado2 { get => lado2; set => lado2 = value; }
        public int Lado3 { get => lado3; set => lado3 = value; }

        public Triangulo(int basee, int altura, int lado1, int lado2, int lado3) : base()
        {
            this.Basee = basee;
            this.Altura = altura;
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
            this.area();
            this.perimetro();
        }
        public override float area()//Polimorfismo
        {
            return (Basee * Altura) / 2;
        }
        public override float perimetro()//Polimorfismo
        {
            return (Lado1 + Lado2 + Lado3);
        }
        public override string ToString()
        {
            return string.Format("Triangulo \t{0}\t{1}\t{2}\t{3}\t{4}\t{5}:Area\t\t{6}:Perimetro\n",
                Basee, Altura, Lado1, Lado2, Lado3, area(), perimetro());
        }
    }
}

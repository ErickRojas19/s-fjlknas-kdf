using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    class Rectangulo : FigurasGeometricas //Herencia
    {
        int basee;
        int altura;

        public int Basee { get => basee; set => basee = value; }
        public int Altura { get => altura; set => altura = value; }

        public Rectangulo(int altura, int basee)
        {
            this.Basee = basee;
            this.Altura = altura;
            this.area();
            this.perimetro();
        }
        public override float area()//Polimorfismo
        {
            return (Basee * Altura);
        }
        public override float perimetro()//Polimorfismo
        {
            return (2 * Basee) + (2 * Altura);
        }
        public override string ToString()
        {
            return string.Format("Rectangulo \t{0}\t{1}\t{2}:Area\t\t{3}:Perimetro\n",
                Basee, Altura, area(), perimetro());
        }
    }
}

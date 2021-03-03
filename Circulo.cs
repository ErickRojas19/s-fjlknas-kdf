using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    class Circulo : FigurasGeometricas //Herencia
    {
        int radio;
        public const double PI=3.1416;
        public int Radio { get => radio; set => radio = value; }

        public Circulo(int radio) : base()
        {
            this.Radio = radio;
        }
        public override float area()//Polimorfismo
        {
            return ((float)(PI * radio* radio)); 
        }
        public override float perimetro()//Polimorfismo
        {
            return ((float)(2 * PI* radio));
        }
        public override string ToString()
        {
            return string.Format("Circulo \t{0}\t{1}:Area\t\t{2}:Perimetro\n",
                radio, area(), perimetro());
        }
    }  
}

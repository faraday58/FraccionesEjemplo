using System;

namespace FraccionesEjemplo
{
    class Fraccion
    {
        private int numerador;
        private int denominador;

        public Fraccion(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }

        public static Fraccion operator -(Fraccion f1, Fraccion f2)
        {
            Fraccion f3 = new Fraccion(f1.numerador * f2.denominador - f1.denominador * f2.numerador,  f1.denominador*f2.denominador );
            return f3;
        }

        public static Fraccion operator *(Fraccion f1, Fraccion f2)
        {
            Fraccion f3 = new Fraccion(f1.numerador * f2.numerador, f1.denominador * f2.denominador);
            return f3;
        }

        public static Fraccion operator /(Fraccion f1, Fraccion f2)
        {
            Fraccion f3 = new Fraccion(f1.numerador * f2.denominador, f1.denominador * f2.numerador);
            return f3;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", numerador, denominador);
        }


    }
}

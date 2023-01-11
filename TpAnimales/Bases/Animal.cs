using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TpAnimales.Bases
{
    public abstract class Animal
    {
        public int Edad { get; } 
        public float Altura { get; }
        public float Peso { get; }

        public Animal() { }
        public Animal(int edad, float altura, float peso)
        {
            Edad= edad;
            Altura= altura; 
            Peso= peso;
        }
        public virtual string Imprimir()
        {
            return "Edad: " + Edad + " Altura: " + Altura + " Peso: " + Peso;
        }

        public abstract string ImprimirComida();
     
        //public virtual string ImprimirComida ();
    }
}

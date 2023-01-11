using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAnimales.Bases;

namespace TpAnimales.Derivadas
{
    public class Loro : Animal
    {
        public Loro() { }
        public Loro(int edad, float altura, float peso,string tamanioPico) : base(edad, altura, peso)
        {
            TamanioPico = tamanioPico;
        }

        public override string ImprimirComida()
        {
            return"Semillas";
        }
        public string TamanioPico { get; set; }

    }
}

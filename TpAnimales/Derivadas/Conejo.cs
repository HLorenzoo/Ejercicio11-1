using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAnimales.Bases;

namespace TpAnimales.Derivadas
{
    public class Conejo : Animal
    {
        public Conejo() { }
        public Conejo(int edad, float altura, float peso,string orejas) : base(edad, altura, peso)
        {
            Orejas= orejas;
        }
        public override string ImprimirComida()
        {
            return "Zanahorias";
        }
        public string Orejas { get; set; }
    }
}

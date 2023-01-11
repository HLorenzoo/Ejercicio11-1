using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAnimales.Bases;

namespace TpAnimales.Derivadas
{
    public class Leon : Animal
    {
        public Leon() { }
        public Leon(int edad, float altura, float peso,string melena) : base(edad, altura, peso)
        {
              Melena= melena;
        }
        public override string ImprimirComida()
        {

           return"Carnes";
        }
        public string Melena { get; set; }
    }
}

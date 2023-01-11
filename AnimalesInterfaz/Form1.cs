using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpAnimales.Derivadas;

namespace AnimalesInterfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loro loro = new Loro(10,45,22,"Pico Grande");
            MessageBox.Show("El loro, su edad:"+loro.Edad+"\naltura : " + loro.Altura + "\nPeso : " + loro.Peso+ "\nTamaño de Pico : " + loro.TamanioPico + "\n\n\tComida Loro: \n" + loro.ImprimirComida());
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon(25, 30, 23,"Voluminosa");
            MessageBox.Show("El leon, su edad:" + leon.Edad + "\naltura : " + leon.Altura + "\nMelena : " + leon.Melena + "\nPeso : " + leon.Peso + "\n\n\tComida leon: \n" + leon.ImprimirComida());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conejo conejo = new Conejo(25, 30, 23,"Puntiagudas");
            MessageBox.Show("El Conejo, su edad:" + conejo.Edad + "\naltura : " + conejo.Altura + "\nPeso : " + conejo.Peso + "\nOrejas : " + conejo.Orejas + "\n\n\tComida Conejo: \n" + conejo.ImprimirComida());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio11_1;
using Ejercicio11_1.Derivadas;

namespace AppGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Peon peon = new Peon();
            MessageBox.Show("\n\t Peon :" +peon.Mover() );
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Caballo caballo = new Caballo();
            MessageBox.Show("\tCaballo : " + caballo.Mover());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Torre torre = new Torre();
            MessageBox.Show("\n\t Torre :" + torre.Mover());

        }
    }
}

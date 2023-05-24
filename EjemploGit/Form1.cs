using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploGit
{
    public partial class Form1 : Form
    {
	private string nombre;
        public Form1()
        {
            InitializeComponent();
        }

        private void Boton_Click(object sender, EventArgs e)
        {
	    //  Ja ja ja
            Console.Write(nombre);
        }
    }
}

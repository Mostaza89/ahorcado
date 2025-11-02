using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahorcado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbtitulo.BackColor = System.Drawing.Color.Transparent;
            lbtitulo.ForeColor = System.Drawing.Color.White;
        }

        private void lbpalabra_Click(object sender, EventArgs e)
        {

        }

        private void bnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnopciones_Click(object sender, EventArgs e)
        {

        }

        private void bniniciar_Click(object sender, EventArgs e)
        {
            Forminiciojuego siguienteForm = new Forminiciojuego();
            siguienteForm.Show();
            this.Hide(); 
        }
    }
}

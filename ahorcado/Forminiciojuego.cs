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
    public partial class Forminiciojuego : Form
    {
        public Forminiciojuego()
        {
            InitializeComponent();
            lb1.BackColor = System.Drawing.Color.Black; 
            lb1.ForeColor = System.Drawing.Color.White; 

            tb1.BackColor = System.Drawing.Color.Black;  
            tb1.ForeColor = System.Drawing.Color.White;  
        }

        private void Forminiciojuego_Load(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void bnpalabra_Click(object sender, EventArgs e)
        {
            string palabraParaAdivinar=tb1.Text;
            
            if (string.IsNullOrWhiteSpace(palabraParaAdivinar))
            {
                MessageBox.Show("Por favor, introduce una palabra");
                return;
            }
            
            Formahorcado formahorcado = new Formahorcado();
            formahorcado.Show();
            this.Hide();

        }
    }
}

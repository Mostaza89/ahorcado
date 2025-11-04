using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ahorcado.Services; // Necesario para GlobalHistorial
using ahorcado.modulologico;

namespace ahorcado
{
    public partial class Formhistorial : Form
    {
        public Formhistorial()
        {
            InitializeComponent();
        }

        private void Formhistorial_Load(object sender, EventArgs e)
        {
            CargarHistorialEnTabla();
        }

        private void CargarHistorialEnTabla()
        {
            var historial = GlobalHistorial.Instance.GetHistorial();

            dgvHistorial.DataSource = historial;

            if (dgvHistorial.Columns.Contains("PalabraSecreta"))
                dgvHistorial.Columns["PalabraSecreta"].HeaderText = "Palabra";

            if (dgvHistorial.Columns.Contains("Resultado"))
                dgvHistorial.Columns["Resultado"].HeaderText = "Resultado";

            if (dgvHistorial.Columns.Contains("IntentosFallidos"))
                dgvHistorial.Columns["IntentosFallidos"].HeaderText = "Errores";

            if (dgvHistorial.Columns.Contains("TiempoFormateado"))
                dgvHistorial.Columns["TiempoFormateado"].HeaderText = "Tiempo (mm:ss)";

            // FIX DEL CHECKBOX (CS0051): Ocultamos la propiedad booleana 'Ganado'
            if (dgvHistorial.Columns.Contains("Ganado"))
                dgvHistorial.Columns["Ganado"].Visible = false;

            // Ocultamos las otras propiedades crudas
            if (dgvHistorial.Columns.Contains("Tiempo"))
                dgvHistorial.Columns["Tiempo"].Visible = false;
            if (dgvHistorial.Columns.Contains("Palabra"))
                dgvHistorial.Columns["Palabra"].Visible = false;
            if (dgvHistorial.Columns.Contains("Fecha"))
                dgvHistorial.Columns["Fecha"].Visible = false; // Puedes decidir si mostrar o no la fecha

            dgvHistorial.AutoResizeColumns();
        }

        private void bnregresar_Click(object sender, EventArgs e)
        {
            Form1 formPrincipal = new Form1();
            formPrincipal.Show();
            this.Close();
        }
    }
}

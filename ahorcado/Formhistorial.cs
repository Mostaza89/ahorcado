using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ahorcado.Services;        
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
            dgvHistorial.Parent = pictureBox1;
            dgvHistorial.BorderStyle = BorderStyle.None;
            dgvHistorial.BackgroundColor = Color.Black; 

            dgvHistorial.EnableHeadersVisualStyles = false;
            dgvHistorial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHistorial.RowHeadersVisible = false;

            dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistorial.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvHistorial.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvHistorial.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgvHistorial.DefaultCellStyle.ForeColor = Color.White;
            dgvHistorial.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 130, 180); // azul acero
            dgvHistorial.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvHistorial.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dgvHistorial.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistorial.GridColor = Color.FromArgb(64, 64, 64); // gris tenue

            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.AllowUserToResizeRows = false;
            dgvHistorial.AllowUserToResizeColumns = false;
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowTemplate.Height = 30;

            dgvHistorial.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
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

            // Ocultar columnas innecesarias
            string[] ocultar = { "Ganado", "Tiempo", "Palabra", "Fecha" };
            foreach (var col in ocultar)
                if (dgvHistorial.Columns.Contains(col))
                    dgvHistorial.Columns[col].Visible = false;

            dgvHistorial.AutoResizeColumns();
        }

        private void bnregresar_Click(object sender, EventArgs e)
        {
            Form1 formPrincipal = new Form1();
            formPrincipal.Show();
            this.Close();
        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

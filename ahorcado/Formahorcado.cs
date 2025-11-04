using ahorcado.modulologico; 
using ahorcado.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ahorcado.modulologico; 
using ahorcado.Services;

namespace ahorcado
{
    public partial class Formahorcado : Form
    {
        private JuegoAhorcado miJuego;
        private Stopwatch stopwatch;

        public Formahorcado(string palabra)
        {
            InitializeComponent();

            miJuego = new JuegoAhorcado(palabra);

            pbAhorcado.BackColor = Color.Transparent;
            flpBotones.BackColor = Color.Transparent;

            // FIX: Asegurar que el PictureBox de vidas exista y sea transparente
            if (pbVidas != null)
                pbVidas.BackColor = Color.Transparent;

            lblPalabra.BackColor = Color.Transparent;
            lblPalabra.ForeColor = Color.White;

            lblErrores.BackColor = Color.Transparent;
            lblErrores.ForeColor = Color.White;

            stopwatch = new Stopwatch();
            stopwatch.Start();


        }

        private void Formahorcado_Load(object sender, EventArgs e)
        {
            GenerarTeclado();
            ActualizarUI();
        }

        private void GenerarTeclado()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Button btnLetra = new Button();
                btnLetra.Text = c.ToString();
                btnLetra.Tag = c;
                btnLetra.Width = 40;
                btnLetra.Height = 40;
                btnLetra.Font = new Font("Arial", 12, FontStyle.Bold);
                btnLetra.Click += Letra_Click;

                flpBotones.Controls.Add(btnLetra);
            }
        }

        private void Letra_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            char letra = (char)btn.Tag;
            btn.Enabled = false;

            miJuego.AdivinarLetra(letra);
            ActualizarUI();
        }

        private void ActualizarUI()
        {
            lblPalabra.Text = miJuego.GetPalabraParaMostrar();
            lblErrores.Text = "Erróneas: " + string.Join(", ", miJuego.LetrasIncorrectas);

            // FIX: Lógica de actualización de pbVidas (DESCOMENTADA)
            int vidasRestantes = miJuego.IntentosRestantes;
            string recursoVida = $"vidas_{vidasRestantes}";

            try
            {
                pbVidas.Image = (Image)Properties.Resources.ResourceManager.GetObject(recursoVida);
                pbVidas.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception)
            {
                // Asegúrate de que las imágenes vidas_0.png a vidas_5.png existan en Resources.
            }

            int imagenNum = 5 - miJuego.IntentosRestantes;

            try
            {
                if (miJuego.Estado != BaseJuego.EstadoJuego.Ganado)
                {
                    pbAhorcado.Image = (Image)Properties.Resources.ResourceManager.GetObject($"ahorcado_{imagenNum}");
                    pbAhorcado.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception)
            {

            }

            // Lógica de fin de juego y guardado de historial
            if (miJuego.Estado == BaseJuego.EstadoJuego.Ganado)
            {
                stopwatch.Stop();

                var partida = new PartidaHistorial
                {
                    Palabra = miJuego.PalabraSecreta,
                    Tiempo = stopwatch.Elapsed,
                    Ganado = true,
                    IntentosFallidos = miJuego.LetrasIncorrectas.Count,
                    Fecha = DateTime.Now
                };

                GlobalHistorial.Instance.AñadirPartida(partida);

                DeshabilitarTeclado();
                MessageBox.Show($"¡GANASTE! Tiempo: {partida.TiempoFormateado}", "Felicidades");

                Form1 inicioForm = new Form1();
                inicioForm.Show();
                this.Close();
            }
            else if (miJuego.Estado == BaseJuego.EstadoJuego.Perdido)
            {
                stopwatch.Stop();

                var partida = new PartidaHistorial
                {
                    Palabra = miJuego.PalabraSecreta,
                    Tiempo = stopwatch.Elapsed,
                    Ganado = false,
                    IntentosFallidos = miJuego.LetrasIncorrectas.Count,
                    Fecha = DateTime.Now
                };

                GlobalHistorial.Instance.AñadirPartida(partida);

                DeshabilitarTeclado();
                MessageBox.Show($"¡PERDISTE! La palabra era: {miJuego.PalabraSecreta}. Tiempo: {partida.TiempoFormateado}", "Suerte la próxima");

                Form1 inicioForm = new Form1();
                inicioForm.Show();
                this.Close();
            }
        }

        private void DeshabilitarTeclado()
        {
            foreach (Control c in flpBotones.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = false;
                }
            }
        }

        private void pbAhorcado_Click(object sender, EventArgs e)
        {

        }

        private void flpBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPalabra_Click(object sender, EventArgs e)
        {

        }

        private void lblErrores_Click(object sender, EventArgs e)
        {

        }

        private void lblIntentos_Click(object sender, EventArgs e)
        {

        }

        private void pbVidas_Click(object sender, EventArgs e)
        {

        }
    }
}

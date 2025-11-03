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
    public partial class Formahorcado : Form
    {
        // Instancia de la clase de lógica del juego
        private JuegoAhorcado miJuego;

        // ***** PASO 1: Modificar el constructor *****
        // Borra el constructor vacío que tenías y pon este:
        public Formahorcado(string palabra)
        {
            InitializeComponent();

            // Crear la instancia del juego con la palabra recibida
            miJuego = new JuegoAhorcado(palabra);
        }

        // ***** PASO 2: Llenar el evento Load *****
        private void Formahorcado_Load(object sender, EventArgs e)
        {
            // Iniciar la interfaz gráfica
            GenerarTeclado();
            ActualizarUI();
        }

        // Método para crear los botones de la A a la Z
        private void GenerarTeclado()
        {
            // El FlowLayoutPanel (flpBotones) los acomodará automáticamente
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Button btnLetra = new Button();
                btnLetra.Text = c.ToString();
                btnLetra.Tag = c; // Guardamos la letra en el Tag
                btnLetra.Width = 40;
                btnLetra.Height = 40;
                btnLetra.Font = new Font("Arial", 12, FontStyle.Bold);
                btnLetra.Click += Letra_Click; // Asignar el mismo evento a todos

                flpBotones.Controls.Add(btnLetra);
            }
        }

        // ***** PASO 3: Crear el evento Click para las letras *****
        private void Letra_Click(object sender, EventArgs e)
        {
            // Obtener el botón que se presionó
            Button btn = (Button)sender;

            // Obtener la letra del Tag
            char letra = (char)btn.Tag;

            // Deshabilitar el botón para que no se use de nuevo
            btn.Enabled = false;

            // Llamar a la lógica del juego
            miJuego.AdivinarLetra(letra);

            // Actualizar toda la pantalla
            ActualizarUI();
        }

        // Método para refrescar toda la pantalla
        private void ActualizarUI()
        {
            // 1. Mostrar la palabra con guiones (ej: H O _ A)
            lblPalabra.Text = miJuego.GetPalabraParaMostrar();

            // 2. Mostrar letras incorrectas
            lblErrores.Text = "Erróneas: " + string.Join(", ", miJuego.LetrasIncorrectas);

            // 3. Mostrar intentos
            lblIntentos.Text = $"Intentos restantes: {miJuego.IntentosRestantes}";

            // 4. (Opcional) Actualizar la imagen del ahorcado
            //    Necesitarías tener imágenes en tus Recursos (ej: img_0, img_1...)
            //    int imagenNum = 6 - miJuego.IntentosRestantes;
            //    pbAhorcado.Image = (Image)Properties.Resources.ResourceManager.GetObject($"img_{imagenNum}");

            // 5. Comprobar si el juego terminó
            if (miJuego.Estado == JuegoAhorcado.EstadoJuego.Ganado)
            {
                MessageBox.Show("¡GANASTE!", "Felicidades");
                DeshabilitarTeclado();
            }
            else if (miJuego.Estado == JuegoAhorcado.EstadoJuego.Perdido)
            {
                MessageBox.Show($"¡PERDISTE! La palabra era: {miJuego.PalabraSecreta}", "Suerte la próxima");
                DeshabilitarTeclado();
            }
        }

        // Método para deshabilitar todos los botones al terminar
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
    }
}

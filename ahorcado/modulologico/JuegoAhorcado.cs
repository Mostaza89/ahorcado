using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahorcado
{
    public class JuegoAhorcado
    {
        // Propiedades públicas para que el formulario las lea
        public string PalabraSecreta { get; private set; }
        public char[] PalabraMostrada { get; private set; }
        public int IntentosRestantes { get; private set; }
        public List<char> LetrasIncorrectas { get; private set; }

        // Enum para saber el estado del juego
        public enum EstadoJuego { Jugando, Ganado, Perdido }
        public EstadoJuego Estado { get; private set; }

        // Constructor: Se llama al iniciar el juego
        public JuegoAhorcado(string palabra)
        {
            PalabraSecreta = palabra.ToUpper(); // Guardar en mayúsculas
            IntentosRestantes = 6; // O los intentos que quieras
            LetrasIncorrectas = new List<char>();
            Estado = EstadoJuego.Jugando;

            // Inicializar la palabra mostrada con guiones bajos
            PalabraMostrada = new char[PalabraSecreta.Length];
            for (int i = 0; i < PalabraSecreta.Length; i++)
            {
                PalabraMostrada[i] = '_';
            }
        }

        // Método principal para adivinar una letra
        public bool AdivinarLetra(char letra)
        {
            letra = char.ToUpper(letra);

            // No hacer nada si el juego terminó o la letra ya se usó
            if (Estado != EstadoJuego.Jugando || LetrasIncorrectas.Contains(letra) || PalabraMostrada.Contains(letra))
            {
                return false;
            }

            // Comprobar si la letra está en la palabra secreta
            if (PalabraSecreta.Contains(letra))
            {
                // Acierto: Revelar la letra en la palabra mostrada
                for (int i = 0; i < PalabraSecreta.Length; i++)
                {
                    if (PalabraSecreta[i] == letra)
                    {
                        PalabraMostrada[i] = letra;
                    }
                }

                // Comprobar si ganó
                if (!PalabraMostrada.Contains('_'))
                {
                    Estado = EstadoJuego.Ganado;
                }
                return true; // Fue un acierto
            }
            else
            {
                // Error: Quitar un intento y guardar la letra incorrecta
                LetrasIncorrectas.Add(letra);
                IntentosRestantes--;

                // Comprobar si perdió
                if (IntentosRestantes <= 0)
                {
                    Estado = EstadoJuego.Perdido;
                }
                return false; // Fue un error
            }
        }

        // Método para obtener la palabra formateada para el Label (ej: C _ S A)
        public string GetPalabraParaMostrar()
        {
            return string.Join(" ", PalabraMostrada);
        }
    }
}
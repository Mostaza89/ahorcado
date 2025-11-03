using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahorcado
{
    public class JuegoAhorcado: modulologico.BaseJuego
    {
        public JuegoAhorcado(string palabra)
        {
            PalabraSecreta = palabra.ToUpper(); // Guardar en mayúsculas
            IntentosRestantes = 5; // Configurado a 5 intentos
            LetrasIncorrectas = new List<char>();
            Estado = EstadoJuego.Jugando;

            // Inicializar la palabra mostrada con guiones bajos
            PalabraMostrada = new char[PalabraSecreta.Length];
            for (int i = 0; i < PalabraSecreta.Length; i++)
            {
                PalabraMostrada[i] = '_';
            }
        }

        // Implementación del método virtual de la clase base usando 'override'
        public override bool AdivinarLetra(char letra)
        {
            letra = char.ToUpper(letra);

            // Usa las propiedades heredadas
            if (Estado != EstadoJuego.Jugando || LetrasIncorrectas.Contains(letra) || PalabraMostrada.Contains(letra))
            {
                return false;
            }

            // Comprobar si la letra está en la palabra secreta (propiedad heredada)
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
    }
}
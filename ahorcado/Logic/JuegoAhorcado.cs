using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ahorcado.modulologico;

namespace ahorcado
{
    public class JuegoAhorcado: modulologico.BaseJuego
    {
        public JuegoAhorcado(string palabra)
        {
            PalabraSecreta = palabra.ToUpper(); 
            IntentosRestantes = 5;
            LetrasIncorrectas = new List<char>();
            Estado = EstadoJuego.Jugando;

            PalabraMostrada = new char[PalabraSecreta.Length];
            for (int i = 0; i < PalabraSecreta.Length; i++)
            {
                PalabraMostrada[i] = '_';
            }
        }

        public override bool AdivinarLetra(char letra)
        {
            letra = char.ToUpper(letra);

            if (Estado != EstadoJuego.Jugando || LetrasIncorrectas.Contains(letra) || PalabraMostrada.Contains(letra))
            {
                return false;
            }

            if (PalabraSecreta.Contains(letra))
            {
                for (int i = 0; i < PalabraSecreta.Length; i++)
                {
                    if (PalabraSecreta[i] == letra)
                    {
                        PalabraMostrada[i] = letra;
                    }
                }

                if (!PalabraMostrada.Contains('_'))
                {
                    Estado = EstadoJuego.Ganado;
                }
                return true;
            }
            else
            {
                LetrasIncorrectas.Add(letra);
                IntentosRestantes--;

                if (IntentosRestantes <= 0)
                {
                    Estado = EstadoJuego.Perdido;
                }
                return false; 
            }
        }
    }
}
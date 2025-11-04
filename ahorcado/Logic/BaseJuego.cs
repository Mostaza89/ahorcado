using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahorcado.modulologico
{
    public class BaseJuego
    {
        public enum EstadoJuego { Jugando, Ganado, Perdido }

        // Propiedades protegidas para que las clases derivadas las usen
        public string PalabraSecreta { get; protected set; }
        public char[] PalabraMostrada { get; protected set; }
        public int IntentosRestantes { get; protected set; }
        public List<char> LetrasIncorrectas { get; protected set; }
        public EstadoJuego Estado { get; protected set; }

        // Método virtual: Permite a JuegoAhorcado reescribir con 'override'
        public virtual bool AdivinarLetra(char letra)
        {
            return false;
        }

        // Método implementado que las clases derivadas heredan
        public string GetPalabraParaMostrar()
        {
            return string.Join(" ", PalabraMostrada);
        }
    }
}

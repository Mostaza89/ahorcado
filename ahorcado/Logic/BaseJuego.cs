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

        public string PalabraSecreta { get; protected set; }
        public char[] PalabraMostrada { get; protected set; }
        public int IntentosRestantes { get; protected set; }
        public List<char> LetrasIncorrectas { get; protected set; }
        public EstadoJuego Estado { get; protected set; }

        public virtual bool AdivinarLetra(char letra)
        {
            return false;
        }

        public string GetPalabraParaMostrar()
        {
            return string.Join(" ", PalabraMostrada);
        }
    }
}

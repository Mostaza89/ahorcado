using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahorcado.modulologico
{
    internal class PartidaHistorial
    {
        public string Palabra { get; set; }
        public TimeSpan Tiempo { get; set; }
        public bool Ganado { get; set; }
        public int IntentosFallidos { get; set; }
        public DateTime Fecha { get; set; }

        public string PalabraSecreta
        {
            get { return Palabra; }
        }

        public string Resultado
        {
            get { return Ganado ? "Ganó" : "Perdió"; }
        }

        public string TiempoFormateado
        {
            get { return Tiempo.ToString(@"mm\:ss"); }
        }
    }
}

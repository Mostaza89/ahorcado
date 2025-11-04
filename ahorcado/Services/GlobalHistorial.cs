using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ahorcado.modulologico;

namespace ahorcado.Services
{
    internal class GlobalHistorial
    {
        private static GlobalHistorial _instance;

        public static GlobalHistorial Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GlobalHistorial();
                }
                return _instance;
            }
        }

        private GlobalHistorial()
        {
            _partidas = new List<PartidaHistorial>();
        }

        private List<PartidaHistorial> _partidas;

        public List<PartidaHistorial> GetHistorial()
        {
            return _partidas;
        }

        public void AñadirPartida(PartidaHistorial partida)
        {
            _partidas.Add(partida);
        }
    }
}

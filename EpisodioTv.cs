using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFilm
{
    internal class EpisodioTv : GenericMedia
    {

        public int Stagione;
        public int numeroEpisodio;

        public override void Play()
        {
            Console.WriteLine
                ($"l'episodio {titolo} \n " +
                $"( stagione {Stagione}, N. Ep: {numeroEpisodio}) \n" +
                $"è in riproduzione al minuto {minutoCorrente()}");
        }

    }
}
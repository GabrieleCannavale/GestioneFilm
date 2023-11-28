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
            Random rnd = new Random();
            int Durata = rnd.Next(1, 61);
            Console.WriteLine("l'episodio" + titolo + " e al minuto  " + Durata);
        }

    }
}
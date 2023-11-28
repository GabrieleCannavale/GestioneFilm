using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFilm
{
    internal class Film : GenericMedia
    {

        public override void Play()
        {
            Random rnd = new Random();
            int Durata = rnd.Next(1, DurataMin);
            Console.WriteLine("il film" + titolo + " e al minuto  " + DurataMin);
        }

    }
}
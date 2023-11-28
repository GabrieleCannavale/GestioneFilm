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
            
            Console.WriteLine($"il film {titolo} è in riproduzione al minuto {minutoCorrente()}");
        }

        
    }
}
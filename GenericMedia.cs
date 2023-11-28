using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFilm
{
    public abstract class GenericMedia : IMedia
    {
        public int DurataMin { get; set; }
        public string? titolo;
        public enum typePremio { Oscar, David, Grammy };

        public typePremio Premio { get; set; }



        public abstract void Play();

        public void Stop()
        {
            Console.WriteLine("la riproduzione è stata stoppata");
        }
    }
}
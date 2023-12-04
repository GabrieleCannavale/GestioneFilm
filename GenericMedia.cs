using Packt.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFilm
{
    public abstract class GenericMedia : IMedia
    {
        public int DurataMin { get; set; } = 0;
        public string? titolo;
        public string? mediaPassword { get; set; }

        public enum typePremio { Oscar, David, Grammy };

        public typePremio Premio { get; set; }

        //public string cryptoTitle {  get; set; } = string.Empty;
        public string cryptoTitle => Protector.Encrypt(titolo, mediaPassword);
        public string clearText => Protector.Decrypt(cryptoTitle, mediaPassword);

        public abstract void Play();

        public void Stop()
        {
            Console.WriteLine("la riproduzione è stata stoppata");
        }

        public int minutoCorrente()
        {
            Random rnd = new Random();
            int Durata = rnd.Next(1, DurataMin + 1);
            return Durata;
        }
    }
}
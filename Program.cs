using System;
using System.Collections.Generic;
using GestioneFilm;
using Newtonsoft.Json;
using Packt.Shared;
using static System.Console;
using static System.Environment;
using static System.IO.Path;
namespace GestioneFilm // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("inserire la pw per criptare i titoli dei media");
            string? passWord = Console.ReadLine();

            //nuovo film
            Film resevoirDogs = new Film();
            resevoirDogs.titolo = "Resevoir Dogs";
            resevoirDogs.Premio = GenericMedia.typePremio.Oscar;
            resevoirDogs.DurataMin =190;
            resevoirDogs.Play();
            resevoirDogs.mediaPassword = passWord;
            Console.WriteLine(resevoirDogs.Premio);
            Console.WriteLine(resevoirDogs.cryptoTitle);

            //nuovo episodio tv
            EpisodioTv breakingBad = new EpisodioTv();
            breakingBad.titolo = "Breaking Bad";
            breakingBad.numeroEpisodio = 1;
            breakingBad.Stagione = 2;
            breakingBad.DurataMin = 49;
            breakingBad.Premio = GenericMedia.typePremio.Grammy;
            breakingBad.Play();
            breakingBad.Stop();

            // nuova lista film e immissione nuovi film
            var tarantinoFilms = new List<Film>
            {
                new Film() {titolo = "DJANGO", DurataMin = 150, Premio = GenericMedia.typePremio.Oscar, mediaPassword = passWord},
                new Film() { titolo = "The hateful 8", DurataMin = 138, Premio = GenericMedia.typePremio.Oscar, mediaPassword = passWord},
                new Film() {titolo = "PULP FICTION", DurataMin = 164, Premio = GenericMedia.typePremio.Oscar, mediaPassword = passWord},
                new Film() { titolo = "Inglorious Bastards", DurataMin = 200, Premio = GenericMedia.typePremio.Oscar, mediaPassword = passWord},
                new Film() {titolo = "KILL BILL", DurataMin = 133, Premio = GenericMedia.typePremio.Oscar, mediaPassword = passWord},
                new Film() { titolo = "KILL BILL 2", DurataMin = 141, Premio = GenericMedia.typePremio.Oscar, mediaPassword = passWord},
                new Film() {titolo = "Once upon a time in Hollywood", DurataMin = 122, Premio = GenericMedia.typePremio.Oscar, mediaPassword = passWord},
                resevoirDogs
            };

            // ciclo forEach per tutti i film della lista
            foreach(var film in tarantinoFilms) 
            {
                Console.WriteLine(film.cryptoTitle);
                film.Play();
            }

            //nuova lista episodi tv e immissione nuovi episodi
            var bobOdenkirkEpisodes = new List<EpisodioTv>
            {
                new EpisodioTv() {titolo = "BetterCallSaul", DurataMin = 60, Stagione = 4, numeroEpisodio = 40, Premio = GenericMedia.typePremio.Grammy},
                new EpisodioTv() {titolo = "Seinfield", DurataMin = 21, Stagione = 3, numeroEpisodio = 31, Premio = GenericMedia.typePremio.Grammy},
                new EpisodioTv() {titolo = "How I Met Your Mother", DurataMin = 30, Stagione = 8, numeroEpisodio = 100, Premio = GenericMedia.typePremio.Grammy},
                breakingBad
            };

            //ciclo foreach per tutti gli episodi della lista
            foreach (var episodio in bobOdenkirkEpisodes)
            {
                episodio.Play();
            }

            //Creo il path del file da utilizzare
            string jsonPath = Combine(CurrentDirectory, "tarantinoFilms.json");

            //Utilizzo la calsse statica del NewtonSoft
            var js2 = JsonConvert.SerializeObject(tarantinoFilms);
            // Utilizzo File.Write all della classe System.IO ( che gestisce in autonomia lo stream )
            File.WriteAllText(jsonPath, js2);

            WriteLine(File.ReadAllText(jsonPath));

            //Rileggere il file serializzato appoggiandolo in una stringa
            string buff = File.ReadAllText(jsonPath);

            //Ricrea la lista di Obj tarantinoFilms a partire dalla stringa Json 
            var loadTarantinoFilms = JsonConvert.DeserializeObject<List<Film>>(buff);


            if (loadTarantinoFilms != null)
            {
                // se l'obj esiste lo scrive a video
               
                    loadTarantinoFilms.ForEach(item => Console.WriteLine($"Il titolo criptato è : {item.cryptoTitle}"));
                
            }
            else
            {
                Console.Write("La Lista di film è vuota");
            }


           

            //Console.WriteLine("inserici una pw per criptare il titolo di resevoir dogs");
            //string cryptoText = Protector.Encrypt(resevoirDogs.titolo, Console.ReadLine());
            //Console.WriteLine("reimmetti la pw per decriptare il titolo");
            //string clearText = Protector.Decrypt(cryptoText, Console.ReadLine());
            //Console.WriteLine($"titolo criptato:{cryptoText}\n titolo decriptato: {clearText}");

            //Interfaccia IMedia 
            //Titolo // string
            //DurataMin // int
            //Premio // Tipologia Enum
            //Metodo // Play





            //Film 
            // Titolo---
            // Durata---
            // Premio ----
            //Tipologia Premio Enum


            //Episodio TV
            //Titolo----
            //Durata---
            //Stagioni
            //Numero Episodio
            //Premio----
            //Tipologia Premio Enum



            //File Audio
            // tipologia File //.mp3 ...





            //Creare una lista di Film

            // Creaiamo una Lista di Episodi


            // Serializzare lista di Film in file
            // Serializzare Episodi in file

            //deserializzare entrambe le liste


            // aggiungere le liste alla lista Generale di interfaccia IMedia


            //Mettere in Play Tutti gli item
            // utilizzando il metodo  dell'interfaccia .Play

            Console.WriteLine("Hello World!");
        }
    }
}
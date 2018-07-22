using Moteur.Metier;
using Moteur.Repositories;
using Moteur.Repositories.Interface;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ISerieRepository serieRepository = new SerieRepository();
            Serie serie = serieRepository.ObtenirSerieParId(456);

            Console.ReadKey();
        }
    }
}

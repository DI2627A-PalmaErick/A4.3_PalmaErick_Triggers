using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class DataService
    {
        public static List<Superheroe> GetSamples()
        {
            List<Superheroe> ejemplos = new List<Superheroe>();

            Superheroe ironman = new Superheroe("Iron Man", @"Assets\Ironman.jpg", true, false, true);
            Superheroe duende = new Superheroe("DuendeVerde", @"Assets\DuendeVerde.jpg", false, false, false);
            Superheroe tormenta = new Superheroe("Tormenta", @"Assets\Tormenta.jpg", true, true, true);

            ejemplos.Add(ironman);
            ejemplos.Add(duende);
            ejemplos.Add(tormenta);

            return ejemplos;
        }
    }
}

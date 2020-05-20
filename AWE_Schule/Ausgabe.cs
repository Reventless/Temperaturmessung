using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AWE_Schule
{
    public static class Ausgabe
    {
        public static void Ausgeben()
        {
            Console.WriteLine("Uhrzeit  Temperatur\n");
            var liste = Messwertschublade.Instance.Auslesen();
            liste.ToList().ForEach(messwert =>
            {
                Console.WriteLine($"{messwert.Zeitpunkt} Uhr  {messwert.Value} Grad");
            });
                     
        }
        public static void MaximaleTemperaturAusgeben()
        {
            var max = Messwertschublade.Instance.Auslesen().ToList().Max(messwert => messwert.Value);
            Console.WriteLine($"Maximale Temperatur: {max} Grad");
        }
        public static void DurchschnittsTemperaturAusgeben()
        {
            var avg = Messwertschublade.Instance.Auslesen().ToList().Average(messwert => messwert.Value);
            Console.WriteLine($"Durschnittliche Temperatur betraegt: {avg} Grad");
        }
    }
}

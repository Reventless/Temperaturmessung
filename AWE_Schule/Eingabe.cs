using System;
using System.Collections.Generic;
using System.Text;

namespace AWE_Schule
{
    public static class Eingabe
    {
        public static void Speichern()
        {
            int stunde;
            for (stunde = 0; stunde < 24; stunde++)
            {
                Console.Write($"Messwert fuer {stunde} Uhr: ");
                var value = Console.ReadLine();
                try
                {
                    var messwert = new Messwert { Zeitpunkt = stunde, Value = float.Parse(value) };
                    Messwertschublade.Instance.Ablegen(messwert);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bitte geben Sie die Daten neu ein: ");
                    stunde--;
                }
                
                }
             
                        
        }
    }
}

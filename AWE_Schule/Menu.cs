using System;
using System.Collections.Generic;
using System.Text;

namespace AWE_Schule
{
    public static class Menu
    {

        public static void Open()
        {
            Console.WriteLine("(1) Messdaten eingeben\n(2) Messdaten ausgeben\n(3) Maximale Messdaten ausgeben\n(4) Durschnittswert ausgeben\n(0) ENDE\n");
            
            try
            {
                var auswahl = int.Parse(Console.ReadLine());
                if (auswahl > 4 || auswahl < 0)
                {
                    throw new InvalidOperationException();
                }
                Console.Clear();

                switch (auswahl)
                {
                    case 0:
                        Console.WriteLine("Auf Wiedersehen!");
                        Environment.Exit(0);
                        break;
                    case 1:
                        Eingabe.Speichern();
                        break;
                    case 2:
                        Ausgabe.Ausgeben();
                        break;
                    case 3:
                        Ausgabe.MaximaleTemperaturAusgeben();
                        break;
                    case 4:
                        Ausgabe.DurchschnittsTemperaturAusgeben();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ihre Eingabe war inkorrekt, bitte wiederholen Sie:\n");
            }
            
        }
    }
}

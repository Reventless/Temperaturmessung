using System;
using System.Collections.Generic;
using System.Text;

namespace AWE_Schule
{
    public class Messwertschublade
    {
        private static Messwertschublade _instance;

        public static Messwertschublade Instance
        {
            get
            {
                if (_instance != null) return _instance;

                _instance = new Messwertschublade();
                return _instance;
            }

        }
        private IList<Messwert> Stauraum = new List<Messwert>();
        public void Ablegen( Messwert messwert)
        {
            Stauraum.Add(messwert);    
        } 
        
        public IEnumerable<Messwert> Auslesen()
        {
            return Stauraum;
        }
    }
}

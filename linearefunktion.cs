using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    class linearefunktion
    {
        //EigenSchaften(Properties)
        //look up:
        public double Anstieg;
        public double YAchsenAbschnitt { get;private set; }
        //Methoden
        // KOnstruktor
        public linearefunktion(double Anstieg, double YAchsenAbschnitt)
        {
            this.Anstieg = Anstieg;
            this.YAchsenAbschnitt = YAchsenAbschnitt;
        }

        // weiter Methoden

        public double berechneNullstelle()
        {
            double nullstelle;
            nullstelle = -YAchsenAbschnitt / Anstieg;
            return nullstelle;
        }
        public double funktionswertberechnnen(double XWert)
        {
            double Funktionswert;
            Funktionswert = XWert*Anstieg+YAchsenAbschnitt;
            return Funktionswert;
        }
    }
}

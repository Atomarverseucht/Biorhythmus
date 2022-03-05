using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biorhythmus
{
    class Biorhythmus
    {
        //SetGet Methoden
        private int sekunde;
        public void setSekunde(int value)
        {
            sekunde = value;
        }
        public int getSekunde()
        {
            return sekunde;
        }
        private int minute;
        public void setMinute(int value)
        {
            minute = value;
        }
        public int getMinute()
        {
            return minute;
        }
        private int stunde;
        public void setStunde(int value)
        {
            stunde = value;
        }
        public int getStunde()
        {
            return stunde;
        }
        private int tag;
        public void setTag(int value)
        {
            tag = value;
        }
        public int getTag()
        {
            return tag;
        }
        private int monat;
        public void setMonat(int value)
        {
            monat = value;
        }
        public int getMonat()
        {
            return monat;
        }
        private int jahr;
        public void setJahr(int value)
        {
            jahr = value;
        }
        public int getJahr()
        {
            return jahr;
        }
        private int tageseitgeburt;
        public void setTageseitgeburt(int value)
        {
            tageseitgeburt = value;
        }
        public int getTageseitgeburt()
        {
            return tageseitgeburt;
        }
        private int tageseitheute;
        public void setTageseitheute(int value)
        {
            tageseitheute = value;
        }
        public int getTageseitheute()
        {
            return tageseitheute;
        }
        
        //setzt Tg/Monat/Jahr auf aktuellen Zeitpunkt
        public void setDatumAufHeute()
        {
            sekunde = DateTime.Now.Second;
            minute = DateTime.Now.Minute;
            stunde = DateTime.Now.Hour;
            tag = DateTime.Now.Day;
            monat = DateTime.Now.Month;
            jahr = DateTime.Now.Year;
        }

        //prüft ob angegebenes Jahr ein Schaltjahr ist
        public bool pruefeSchaltjahr(int jahr)
        {
            return ((jahr % 4 == 0) && (jahr % 100 != 0)) || (jahr % 400 == 0);
        }

        // gibt aus wieviele tage der Monat hat
        public int berechneMonatstage(int monat)
        {
            int tage;
            switch (monat)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: tage = 31; break;
                case 4:
                case 6:
                case 9:
                case 11: tage = 30; break;
                case 2:
                    if (pruefeSchaltjahr(jahr))
                    { tage = 29; }
                    else tage = 28; break;
                default: tage = 0; break;
            }
            return tage;
        }

        // berechnet wieviele Tage seit der Geburt vergangen sind
        public int berechneTagesdifferenz(int geburtstag, int geburtsmonat, int geburtsjahr)
        {
            setDatumAufHeute();
            int tage = 0;
            int anzahl = 0;
            int tage2 = 0;

            // Berechnung Tage von Anfang momentanen Jahr bis momentanen Monat
            for (int i = 1; i < monat; i++)
            {
                tage = tage + berechneMonatstage(i);
            }

            // Berechnung Tage von Anfang Geburtsjahres bis Geburtsmonat
            for (int g = 1; g < geburtsmonat; g++)
            {
                tage2 = tage2 + berechneMonatstage(g);
            }

            // Berechnung Anzahl der Schaltjahre
            for (int h = geburtsjahr; h < jahr; h++)
            {
                if (pruefeSchaltjahr(h))
                {
                    anzahl++;
                }
            }
            tageseitgeburt = (jahr - geburtsjahr) * 365 + anzahl + tage + tag - tage2 - geburtstag; // speichert den letzten Wert (von unten)
            return (jahr - geburtsjahr) * 365 + anzahl + tage + tag - tage2 - geburtstag; // Tage seit Geburt = Anzahl an Jahre * Anzahl an Tagen im Jahr + Bonustage an Schaltjahren + Ergebnis Schleife 1 - Ergebnis Schleife 2 - Tag der geburt + momentaner Tag
        }

        //berechnet die kondition Körperlich/Geistig/Psychisch
        public double berechneKonditionKoerperlich(int tageSeitHeute)
        {
            int koerperlicherRhythmus = 23;
            return 50 * (1 + Math.Sin(2 * Math.PI * (tageseitgeburt + tageSeitHeute) / koerperlicherRhythmus));
        }
        public double berechneKonditionGeistig(int tageSeitHeute)
        {
            int geistigerRhythmus = 33;
            return 50 * (1 + Math.Sin(2 * Math.PI * (tageseitgeburt + tageSeitHeute) / geistigerRhythmus));
        } //--------------------------------------------------------------------- 
        public double berechneKonditionPsychisch(int tageSeitHeute)
        {
            int psychischerRythmus = 28;
            return 50 * (1 + Math.Sin(2 * Math.PI * (tageseitgeburt + tageSeitHeute) / psychischerRythmus));
        } //--------------------------------------------------------------------- 

        //berechnet Kondition für nächste 14 Tage (für die Tabelle)
        public string erzeugeKonditionPrognose_14Tage()
        {
            string prognose_14Tage = "";
            for (int t = 1; t <= 14; t++)
            {
                prognose_14Tage = prognose_14Tage + " " + t + " \t" + Math.Round(berechneKonditionKoerperlich(t), 0) + " \t\t" + Math.Round(berechneKonditionGeistig(t), 0) + " \t\t" + Math.Round(berechneKonditionPsychisch(t), 0) + "\n";
            }
            return prognose_14Tage;
        }
    }
}

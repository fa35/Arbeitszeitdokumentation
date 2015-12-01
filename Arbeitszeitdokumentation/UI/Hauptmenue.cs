using Arbeitszeitdokumentation.BusinessLogic;
using System;

namespace Arbeitszeitdokumentation.UI
{
    public class Hauptmenue
    {
        private IBusinessLogic fachkonzept;

        public Hauptmenue(IBusinessLogic fachkonzept)
        {
            this.fachkonzept = fachkonzept;
        }

        public void Intro()
        {
            Console.Clear();
            bool zurueck = false;
            do
            {
                print();
                ConsoleKeyInfo eingabe = Console.ReadKey();
                switch (eingabe.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        Mitarbeiter oMitarbeiter = new Mitarbeiter(fachkonzept);
                        oMitarbeiter.Mmitarbeiter();
                        zurueck = true;
                        break;
                    case '2':
                        Console.Clear();
                        Projekte oProjekte = new Projekte(fachkonzept);
                        oProjekte.Projekt();
                        zurueck = true;
                        break;
                    case '3':
                        Console.Clear();
                        Arbeitszeiten oArbeitszeiten = new Arbeitszeiten(fachkonzept);
                        oArbeitszeiten.Arbeitszeit();
                        break;
                    case '4':
                        //Beenden der Console
                        zurueck = true;
                        break;
                    //case (char)ConsoleKey.Escape: 
                    //    zurueck = true;
                    //    break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Dies war keine gültige Eingabe. Bitte geben sie eine Zahl zwischen 1 und 4 ein.");
                        break;
                }
            } while (zurueck == false);
        }

        void print()
        {
            Console.WriteLine("Herzlich Willkommen im Arbeitszeit-Dokumentationssystem");
            Console.WriteLine("");
            Console.WriteLine("Bitte wählen sie aus, in welchem Bereich sie arbeiten möchten.");
            Console.WriteLine("1    Mitarbeiter");
            Console.WriteLine("2    Projekte");
            Console.WriteLine("3    Arbeitszeiten");
            Console.WriteLine("4    Beenden");
            Console.WriteLine("");
        }
    }
}

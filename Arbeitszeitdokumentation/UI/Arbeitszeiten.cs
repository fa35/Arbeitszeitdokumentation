using System;
using Arbeitszeitdokumentation.Container;
using Arbeitszeitdokumentation.BusinessLogic;

namespace Arbeitszeitdokumentation.UI
{
    class Arbeitszeiten
    {
        private IBusinessLogic fachkonzept;

        public Arbeitszeiten(IBusinessLogic fachkonzept)
        {
            this.fachkonzept = fachkonzept;
        }

        public bool Arbeitszeit()
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
                        //Auflistung
                        Console.Clear();
                        printArbeitszeiten();
                        break;
                    case '2':
                        //Hinzufügen
                        addArbeitszeiten();
                        Console.Clear();
                        break;
                    case '3':
                        //Löschen
                        deleteArbeitszeiten();
                        //Mittwoch
                        break;
                    case '4':
                        //Zurück zum Hauptmenue
                        return false;
                    case '5':
                        //beenden der Console
                        return true;
                    default:
                        //Fehleingabe
                        Console.Clear();
                        Console.WriteLine("Dies war keine gültige Eingabe. Bitte geben sie eine Zahl zwischen 1 und 5 ein.\n");
                        break;

                }
            } while (zurueck == false);
            throw new Exception("Fehler in Arbeitszeitenschleife");
        }

        private void deleteArbeitszeiten()
        {
            Console.WriteLine("Welchen Eintrag möchten sie löschen? Bitte geben sie die Id an.");
            var tmp = Console.ReadLine();
            bool ArbeitszeitenIdCorrect;
            int Id;
            if (ArbeitszeitenIdCorrect = int.TryParse(tmp, out Id))
            {
                try
                {
                    fachkonzept.DeleteWorklog(Id);
                    Console.Clear();
                    Console.WriteLine("Projekteintrag mit der ID " + Id + " erfolgreich gelöscht.\n");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Es gibt keinen Eintrag mit ID " + Id + "!\n");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Falsche Eingabe. Bitte erneut eingeben.\n");
            }
        }


        private void printArbeitszeiten()
        {
            var workloglist = fachkonzept.GetWorklogs();

            foreach (Worklog worklogElement in workloglist)
            {
                //Console.WriteLine("Ich bin das Project mit der ID {1}, dem Mitarbeiter ID:{3} mit Start:{2} und Ende:{0}\n"
                //    , worklogElement.ProjectId, worklogElement.EmployeeId, worklogElement.Start, worklogElement.End);
                Console.WriteLine("Id: \t" + worklogElement.Id);
                Console.WriteLine("ProjectId: \t" + worklogElement.ProjectId);
                Console.WriteLine("EmployeeId: \t" + worklogElement.EmployeeId);
                Console.WriteLine("Start: \t\t" + worklogElement.Start);
                Console.WriteLine("End: \t\t" + worklogElement.End + "\n");
            }

        }

        void print()
        {
            //Menue
            Console.WriteLine("Sie haben sich für den Bereich Arbeitszeiten entschieden.");
            Console.WriteLine("Was möchten sie tun?");
            Console.WriteLine("1    Arbeitszeiten auflisten");
            Console.WriteLine("2    Arbeitszeiten hinzufügen");
            Console.WriteLine("3    Arbeitszeiten löschen");
            Console.WriteLine("4    Zurück zum Hauptmenue");
            Console.WriteLine("5    Beenden");
            Console.WriteLine("");
        }

        void addArbeitszeiten()
        {
            //Menue für das Hinzufügen
            Console.Write("Bitte geben sie die Id des Mitarbeiters an:");
            var EmployeeId = Console.ReadLine();
            Console.WriteLine("Bitte geben sie den Start an:");
            var start = Console.ReadLine();
            Console.WriteLine("Bitte geben sie das Ende an:");
            var ende = Console.ReadLine();
            Console.WriteLine("Bitte geben sie die Projekt ID an:");
            var ProjectId = Console.ReadLine();

            var Wworklog = new Worklog();
            //Überprüfung der Eingaben
            int Id1; //ID für Mitarbeiter
            int Id2; //ID für Projekte
            bool employeeIdCorrect;
            bool projectIdCorrect;
            if (employeeIdCorrect = int.TryParse(EmployeeId, out Id1))
            { Wworklog.EmployeeId = Id1; }
            if (projectIdCorrect = int.TryParse(ProjectId, out Id2))
            { Wworklog.ProjectId = Id2; }

            Wworklog.Start = start;
            Wworklog.End = ende;

            if (employeeIdCorrect == true && projectIdCorrect == true)
            {
                //Weiterleitung an das Fachkonzept
                fachkonzept.AddWorklog(Wworklog);
            }
            else
            {
                //Fehleingabe
                Console.WriteLine("Eingabe nicht korrekt. Bitte erneut einegeben!");
                Console.ReadKey();
            }
        }
    }
}

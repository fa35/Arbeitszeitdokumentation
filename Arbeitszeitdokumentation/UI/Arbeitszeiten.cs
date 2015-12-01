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

        public void Arbeitszeit()
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
                        Console.Clear();
                        //Mittwoch
                        return;
                    case '4':
                        //Zurück zum Hauptmenue
                        zurueck = true;
                        return;
                    case '5':
                        //beenden der Console
                        zurueck = true;
                        break;
                    default:
                        //Fehleingabe
                        Console.Clear();
                        Console.WriteLine("Dies war keine gültige Eingabe. Bitte geben sie eine Zahl zwischen 1 und 4 ein.\n");
                        break;

                }
            } while (zurueck == false);
        }

        private void printArbeitszeiten()
        {
            var workloglist = fachkonzept.GetWorklogs();

            foreach (Worklog worklogElement in workloglist)
            {
                //Console.WriteLine("Ich bin das Project mit der ID {1}, dem Mitarbeiter ID:{3} mit Start:{2} und Ende:{0}\n"
                //    , worklogElement.ProjectId, worklogElement.EmployeeId, worklogElement.Start, worklogElement.End);
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

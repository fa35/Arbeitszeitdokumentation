using System;
using Arbeitszeitdokumentation.Container;
using Arbeitszeitdokumentation.BusinessLogic;

namespace Arbeitszeitdokumentation.UI
{
    class Projekte
    {
        private IBusinessLogic fachkonzept;

        public Projekte(IBusinessLogic fachkonzept)
        {
            this.fachkonzept = fachkonzept;
        }

        public bool Projekt()
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
                        printProjekte();
                        break;
                    case '2':
                        addProjekte();
                        Console.Clear();
                        //Logik für AddProject
                        break;
                    case '3':
                        deleteProjekte();
                        //Logik für DeleteProject
                        break;
                    case '4':
                        //Zurück zum Hauptmenue
                        return false;
                    case '5':
                        //beenden der Console
                        return true;
                    default:
                        Console.Clear();
                        Console.WriteLine("Dies war keine gültige Eingabe. Bitte geben sie eine Zahl zwischen 1 und 5 ein.");
                        break;
                }
            } while (zurueck == false);
            throw new Exception("Fehler in Projektschleife");
        }
        //ToDo {
        private void deleteProjekte()
        {
            Console.WriteLine("Welchen Eintrag möchten sie löschen? Bitte geben sie die Id an.");
            var tmp = Console.ReadLine();
            bool projectIdCorrect;
            int Id;
            if (projectIdCorrect = int.TryParse(tmp, out Id))
            {
                try
                {
                    fachkonzept.DeleteProject(Id);
                    Console.Clear();
                    Console.WriteLine("Projekteintrag mit der ID " + Id + " erfolgreich gelöscht.\n");
                }catch (ArgumentException e)
                    {
                        Console.WriteLine("Es gibt keinen Eintrag mit ID "+Id+"!\n");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Falsche Eingabe. Bitte erneut eingeben.\n");
            }

        }//}

        private void printProjekte()
        {
            var projectList = fachkonzept.GetProjects();

            foreach (Project ProjektElement in projectList)
            {
                Console.WriteLine("Id: \t"+ProjektElement.Id);
            Console.WriteLine("Bezeichnung: \t"+ProjektElement.Title);
            Console.WriteLine("Ort: \t"+ProjektElement.Location);
            Console.WriteLine("Start: \t"+ProjektElement.Start);
            Console.WriteLine("Ende: \t"+ProjektElement.End+"\n");
            }

        }

        private void addProjekte()
        {
            Console.WriteLine("Bitte geben sie den Ort des Projektes an: ");
            var ort = Console.ReadLine();
            Console.WriteLine("Bitte geben sie die Bezeichnung des Projektes an: ");
            var title = Console.ReadLine();
            Console.WriteLine("Bitte geben sie Projektstart an: ");
            var start = Console.ReadLine();
            Console.WriteLine("Bitte geben sie Projektende an: ");
            var ende = Console.ReadLine();

            var Pprojekte = new Project();
            Pprojekte.Location = ort;
            Pprojekte.Title = title;
            Pprojekte.Start = start;
            Pprojekte.End = ende;

            fachkonzept.AddProject(Pprojekte);
        }


        void print()
        {
            Console.WriteLine("Sie haben sich für den Bereich Projekte entschieden.");
            Console.WriteLine("Was möchten sie tun?");
            Console.WriteLine("1    Projekte auflisten");
            Console.WriteLine("2    Projekt hinzufügen");
            Console.WriteLine("3    Projekt löschen");
            Console.WriteLine("4    Zurück zum Hauptmenue");
            Console.WriteLine("5    Beenden");
            Console.WriteLine("");


        }
    }
}
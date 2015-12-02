using System;
using Arbeitszeitdokumentation.Container;
using Arbeitszeitdokumentation.BusinessLogic;

namespace Arbeitszeitdokumentation.UI
{
    class Mitarbeiter
    {
        private IBusinessLogic fachkonzept;

        public Mitarbeiter(IBusinessLogic fachkonzept)
        {
            this.fachkonzept = fachkonzept;
        }

        public bool Mmitarbeiter()
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
                        printMitarbeiter();
                        break;
                    case '2':
                        //Hinzufügen
                        addMitarbeiter();
                        Console.Clear();
                        break;
                    case '3':
                        //Mittwoch
                        deleteMitarbeiter();
                        //Löschen
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

            throw new Exception("Fehler in Mitarbeiterschleife");
        }

        private void deleteMitarbeiter()
        {
            Console.WriteLine("Welchen Eintrag möchten sie löschen? Bitte geben sie die Id an.");
            var tmp = Console.ReadLine();
            bool MitarbeiterIdCorrect;
            int Id;
            if (MitarbeiterIdCorrect = int.TryParse(tmp, out Id))
            {
                try
                {
                    fachkonzept.DeleteProject(Id);
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

        private void printMitarbeiter()
        {
            var employeeList = fachkonzept.GetEmployees();

            foreach (Employee employeeElement in employeeList)
            {
                Console.WriteLine("Id: \t" + employeeElement.Id);
                Console.WriteLine("Name: \t" + employeeElement.LastName);
                Console.WriteLine("Vorname: \t" + employeeElement.FirstName);
                Console.WriteLine("Beruf: \t" + employeeElement.Profession + "\n");
            }
        }

        private void addMitarbeiter() //Werden Mitarbeiter anders gespeichert/ausgelesen? Ich bekomme keinen Fehler aber auch keine Daten.
        {
            Console.WriteLine("Bitte geben sie den Familiennamen des Mitarbeiters an:");
            var name = Console.ReadLine();
            Console.WriteLine("Bitte geben sie den Vornamen des Mitarbeiters an:");
            var firstname = Console.ReadLine();
            Console.WriteLine("Bitte geben sie den Beruf des Mitarbeiters an.");
            var profession = Console.ReadLine();

            var Eemployee = new Employee();
            Eemployee.LastName = name;
            Eemployee.FirstName = firstname;
            Eemployee.Profession = profession;

            fachkonzept.AddEmployee(Eemployee);
        }

        void print()
        {
            Console.WriteLine("Sie haben sich für den Bereich Mitarbeiter entschieden.");
            Console.WriteLine("Was möchten sie tun?");
            Console.WriteLine("1    Mitarbeiter auflisten");
            Console.WriteLine("2    Mitarbeiter hinzufügen");
            Console.WriteLine("3    Mitarbeiter löschen");
            Console.WriteLine("4    Zurück zum Hauptmenue");
            Console.WriteLine("5    Beenden");
            Console.WriteLine("");
        }

    }
}

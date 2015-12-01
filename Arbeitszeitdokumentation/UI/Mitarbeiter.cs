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
        
        public void Mmitarbeiter()
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
                        addMitarbeiter();
                        Console.Clear();
                        //Hinzufügen
                        break;
                    case'3':
                        //Mittwoch
                        //Löschen
                        break;
                    case '4':
                        //Zurück zum Hauptmenue
                        zurueck = true;
                        return;
                    case '5':
                        //beenden der Console
                        zurueck = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Dies war keine gültige Eingabe. Bitte geben sie eine Zahl zwischen 1 und 4 ein.");
                        break;
                }
            } while (zurueck == false);
        }

        private void printMitarbeiter()
        {
            var employeeList = fachkonzept.GetEmployees();

            foreach (Employee employeeElement in employeeList)
            {
                Console.WriteLine("Name: \t"+employeeElement.LastName);
                Console.WriteLine("Vorname: \t"+employeeElement.FirstName);
                Console.WriteLine("Beruf: \t"+employeeElement.Profession+"\n");
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
            Console.Clear();
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

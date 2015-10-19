namespace Arbeitszeitdokumentation.Container
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Id { get; set; }

        public string Profession { get; set; }
        
        public Employee(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public override string ToString()
        {
            return string.Format("FirstName: {0}, LastName: {1}, Id: {2}, Profession: {3}", FirstName, LastName, Id, Profession);
        }
    }
}

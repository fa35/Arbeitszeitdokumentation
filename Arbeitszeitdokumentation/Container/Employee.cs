namespace Arbeitszeitdokumentation.Container
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public Employee(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public override string ToString()
        {
            return string.Format("FirstName: {0}, LastName: {1}", FirstName, LastName);
        }
    }
}

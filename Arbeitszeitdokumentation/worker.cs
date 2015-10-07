using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitszeitdokumentation
{
    public class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public Worker(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }
    }
}

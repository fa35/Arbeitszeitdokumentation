using System;
using System.Collections.Generic;
using Arbeitszeitdokumentation.Container;
using Arbeitszeitdokumentation.Storage;

namespace Arbeitszeitdokumentation.Controller
{
    /// <summary>
    /// Summary description for Controller
    /// </summary>
    public class Controller : IController
    {

        private IStorage _storage;

        public Controller(IStorage storage)
        {
            this._storage = storage;
        }

        public void CreateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}

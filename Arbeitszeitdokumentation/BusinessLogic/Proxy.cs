using System;
using System.Collections.Generic;
using Arbeitszeitdokumentation.Container;
using Arbeitszeitdokumentation.Storage;

namespace Arbeitszeitdokumentation.BusinessLogic
{
    /// <summary>
    /// Summary description for Proxy
    /// </summary>
    public class Proxy : IBusinessLogic
    {

        private IStorage _storage;

        public Proxy(IStorage storage)
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

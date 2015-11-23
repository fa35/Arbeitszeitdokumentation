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
            return _storage.GetEmployees();
        }

        public List<Project> GetProjects()
        {
            return _storage.GetProjects();
        }

        public List<Worklog> GetWorklogs()
        {
            return _storage.GetWorklogs();
        }

        public void AddEmployee(Employee employee)
        {
            _storage.AddEmployee(employee);
        }

        public void AddProject(Project project)
        {
            _storage.AddProject(project);
        }

        public void AddWorklog(Worklog worklog)
        {
            _storage.AddWorklog(worklog);
        }

        public void UpdateEmployee(Employee employee)
        {
            _storage.UpdateEmployee(employee);
        }

        public void UpdateProject(Project project)
        {
            _storage.UpdateProject(project);
        }

        public void UpdateWorklog(Worklog worklog)
        {
            _storage.UpdateWorklog(worklog);
        }

        public void DeleteEmployee(int id)
        {
            _storage.DeleteEmployee(id);
        }

        public void DeleteProject(int id)
        {
            _storage.DeleteProject(id);
        }

        public void DeleteWorklog(int id)
        {
            _storage.DeleteWorklog(id);
        }
    }
}

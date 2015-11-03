using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arbeitszeitdokumentation.Container;

namespace Arbeitszeitdokumentation.Storage
{
    class MockStorage : IStorage
    {
        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjects()
        {
            throw new NotImplementedException();
        }

        public List<Worklog> GetWorklogs()
        {
            throw new NotImplementedException();
        }

        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void AddProject(Project project)
        {
            throw new NotImplementedException();
        }

        public void AddWorklog(Worklog worklog)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public void UpdateWorklog(Worklog worklog)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteProject(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteWorklog(int id)
        {
            throw new NotImplementedException();
        }
    }
}

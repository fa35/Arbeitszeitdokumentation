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

        private List<Employee> _employees = new List<Employee>();
        private List<Project> _projects = new List<Project>();
        private List<Worklog> _worklogs = new List<Worklog>();


        public MockStorage()
        {
            Employee marioSuper = new Employee("Super", "Mario");
            marioSuper.Profession = "Klempner";
            AddEmployee(marioSuper);

            Employee gordenFreeman = new Employee("Freeman", "Gorden");
            gordenFreeman.Profession = "Physiker";
            AddEmployee(gordenFreeman);

            Project BER = new Project();
            BER.Location = "Berlin";
            BER.Title = "Flughafen Berlin Brandenbug";
            BER.Start = "1157457600";
            BER.End = "1504612800";
            AddProject(BER);

            Worklog foo = new Worklog();
            foo.EmployeeId = 1;
            foo.ProjectId = 1;
            foo.Start = "1448276947";
            foo.End = "1448301924";
            AddWorklog(foo);
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public List<Project> GetProjects()
        {
            return _projects;
        }

        public List<Worklog> GetWorklogs()
        {
            return _worklogs;
        }

        public void AddEmployee(Employee employee)
        {
            if (_employees.Count > 0)
            {
                int highestId = _employees[_employees.Count - 1].Id;
                employee.Id = highestId + 1;
            }
            else
            {
                employee.Id = 1;
            }
            _employees.Add(employee);
        }

        public void AddProject(Project project)
        {
            if (_projects.Count > 0)
            {
                int highestId = _projects[_projects.Count - 1].Id;
                project.Id = highestId + 1;
            }
            else
            {
                project.Id = 1;
            }
            _projects.Add(project);
        }

        public void AddWorklog(Worklog worklog)
        {
            if (_worklogs.Count > 0)
            {
                int highestId = _worklogs[_worklogs.Count - 1].Id;
                worklog.Id = highestId + 1;
            }
            else
            {
                worklog.Id = 1;
            }

            _worklogs.Add(worklog);
        }

        public void UpdateEmployee(Employee updatedEmployee)
        {
            Employee employee = _employees.FirstOrDefault(o => o.Id == updatedEmployee.Id);
            if (employee != null)
            {
                employee = updatedEmployee;
            }
            else
            {
                throw new ArgumentException("Employee not found in storage.");
            }
        }

        public void UpdateProject(Project updatedProject)
        {
            Project project = _projects.FirstOrDefault(o => o.Id == updatedProject.Id);
            if (project != null)
            {
                project = updatedProject;
            }
            else
            {
                throw new ArgumentException("Project not found in storage.");
            }
        }

        public void UpdateWorklog(Worklog updatedWorklog)
        {
            Worklog worklog = _worklogs.FirstOrDefault(o => o.Id == updatedWorklog.Id);
            if (worklog != null)
            {
                worklog = updatedWorklog;
            }
            else
            {
                throw new ArgumentException("Worklog not found in storage.");
            }
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = _employees.SingleOrDefault(x => x.Id == id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
            else
            {
                throw new ArgumentException("Employee not found in storage.");
            }
        }

        public void DeleteProject(int id)
        {
            Project project = _projects.SingleOrDefault(x => x.Id == id);
            if (project != null)
            {
                _projects.Remove(project);
            }
            else
            {
                throw new ArgumentException("Project not found in storage.");
            }
        }

        public void DeleteWorklog(int id)
        {
            Worklog worklog = _worklogs.SingleOrDefault(x => x.Id == id);
            if (worklog != null)
            {
                _worklogs.Remove(worklog);
            }
            else
            {
                throw new ArgumentException("Worklog not found in storage.");
            }
        }
    }
}

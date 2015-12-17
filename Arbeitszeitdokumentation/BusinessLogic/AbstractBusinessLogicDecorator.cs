using System.Collections.Generic;
using Arbeitszeitdokumentation.Container;
using Arbeitszeitdokumentation.Storage;

namespace Arbeitszeitdokumentation.BusinessLogic
{
    public abstract class AbstractBusinessLogicDecorator : IBusinessLogic
    {
        protected IBusinessLogic BusinessLogic;


        public AbstractBusinessLogicDecorator(IStorage storage)
        {
            BusinessLogic = new BusinessLogic.Proxy(storage);
        }

        public AbstractBusinessLogicDecorator(IBusinessLogic businessLogic)
        {
            BusinessLogic = businessLogic;
        }
        
        public virtual List<Employee> GetEmployees()
        {
            return BusinessLogic.GetEmployees();
        }

        public virtual List<Project> GetProjects()
        {
            return BusinessLogic.GetProjects();
        }

        public virtual List<Worklog> GetWorklogs()
        {
            return BusinessLogic.GetWorklogs();
        }

        public void AddEmployee(Employee employee)
        {
            BusinessLogic.AddEmployee(employee);
        }

        public void AddProject(Project project)
        {
            BusinessLogic.AddProject(project);
        }

        public void AddWorklog(Worklog worklog)
        {
            BusinessLogic.AddWorklog(worklog);
        }

        public void UpdateEmployee(Employee employee)
        {
            BusinessLogic.UpdateEmployee(employee);
        }

        public void UpdateProject(Project project)
        {
            BusinessLogic.UpdateProject(project);
        }

        public void UpdateWorklog(Worklog worklog)
        {
            BusinessLogic.UpdateWorklog(worklog);
        }

        public void DeleteEmployee(int id)
        {
            BusinessLogic.DeleteEmployee(id);
        }

        public void DeleteProject(int id)
        {
            BusinessLogic.DeleteProject(id);
        }

        public void DeleteWorklog(int id)
        {
            BusinessLogic.DeleteWorklog(id);
        }
    }
}

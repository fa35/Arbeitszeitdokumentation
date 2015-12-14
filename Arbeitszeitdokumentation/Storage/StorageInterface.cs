using System.Collections.Generic;
using Arbeitszeitdokumentation.Container;


namespace Arbeitszeitdokumentation.Storage
{
    public interface IStorage
    {
        List<Employee> GetEmployees();
        List<Project> GetProjects();
        List<Worklog> GetWorklogs();

        void AddEmployee(Employee employee);

        void AddProject(Project project);

        void AddWorklog(Worklog worklog);

        void UpdateEmployee(Employee employee);

        void UpdateProject(Project project);

        void UpdateWorklog(Worklog worklog);

        void DeleteEmployee(int id);

        void DeleteProject(int id);

        void DeleteWorklog(int id);
    }
}

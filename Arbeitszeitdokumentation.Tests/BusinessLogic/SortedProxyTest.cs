using System;
using System.Collections.Generic;
using Arbeitszeitdokumentation.BusinessLogic;
using Arbeitszeitdokumentation.Container;
using NUnit.Framework;

namespace Arbeitszeitdokumentation.Tests.BusinessLogic
{
    [TestFixture]
    public class TestSortedController
    {

        public class TheGetEmployeesMethod
        {
            [Test]
            public void UnsortedList()
            {
                var unsortedEmployeeList = new List<Employee> { new Employee("A", "X"), new Employee("C", "X"), new Employee("B", "X") };
                IBusinessLogic mokupProxy = new ProxyMockup(unsortedEmployeeList);
                IBusinessLogic sortedProxy = new SortedProxy(mokupProxy);
                var actualResult = sortedProxy.GetEmployees();
                var expectedResult = new List<Employee> { new Employee("A", "X"), new Employee("B", "X"), new Employee("C", "X") };
                Assert.AreEqual(expectedResult[0].ToString(), actualResult[0].ToString());
                Assert.AreEqual(expectedResult[1].ToString(), actualResult[1].ToString());
                Assert.AreEqual(expectedResult[2].ToString(), actualResult[2].ToString());
            }

            [Test]
            public void SortedList()
            {
                var unsortedEmployeeList = new List<Employee> { new Employee("A", "X"), new Employee("B", "X"), new Employee("C", "X") };
                IBusinessLogic mokupProxy = new ProxyMockup(unsortedEmployeeList);
                IBusinessLogic sortedProxy = new SortedProxy(mokupProxy);
                var actualResult = sortedProxy.GetEmployees();
                var expectedResult = new List<Employee> { new Employee("A", "X"), new Employee("B", "X"), new Employee("C", "X") };
                Assert.AreEqual(expectedResult[0].ToString(), actualResult[0].ToString());
                Assert.AreEqual(expectedResult[1].ToString(), actualResult[1].ToString());
                Assert.AreEqual(expectedResult[2].ToString(), actualResult[2].ToString());
            }
        }

        class ProxyMockup : IBusinessLogic
        {
            public ProxyMockup(List<Employee> employeeList)
            {
                EmployeeList = employeeList;
            }

            public List<Employee> EmployeeList { get; set; }

            public void CreateEmployee(Employee employee)
            {
                throw new NotImplementedException();
            }

            public List<Employee> GetEmployees()
            {
                return EmployeeList;
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
}

using System;
using System.Collections.Generic;
using Arbeitszeitdokumentation.Container;
using Arbeitszeitdokumentation.Controller;

using NUnit.Framework;

namespace Arbeitszeitdokumentation.Tests.Controller
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
                IController mokupController = new ControllerMockup(unsortedEmployeeList);
                IController sortedController = new SortedController(mokupController);
                var actualResult = sortedController.GetEmployees();
                var expectedResult = new List<Employee> { new Employee("A", "X"), new Employee("B", "X"), new Employee("C", "X") };
                Assert.AreEqual(expectedResult[0].ToString(), actualResult[0].ToString());
                Assert.AreEqual(expectedResult[1].ToString(), actualResult[1].ToString());
                Assert.AreEqual(expectedResult[2].ToString(), actualResult[2].ToString());
            }

            [Test]
            public void SortedList()
            {
                var unsortedEmployeeList = new List<Employee> { new Employee("A", "X"), new Employee("B", "X"), new Employee("C", "X") };
                IController mokupController = new ControllerMockup(unsortedEmployeeList);
                IController sortedController = new SortedController(mokupController);
                var actualResult = sortedController.GetEmployees();
                var expectedResult = new List<Employee> { new Employee("A", "X"), new Employee("B", "X"), new Employee("C", "X") };
                Assert.AreEqual(expectedResult[0].ToString(), actualResult[0].ToString());
                Assert.AreEqual(expectedResult[1].ToString(), actualResult[1].ToString());
                Assert.AreEqual(expectedResult[2].ToString(), actualResult[2].ToString());
            }
        }

        class ControllerMockup : IController
        {
            public ControllerMockup(List<Employee> employeeList)
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
        }
    }
}

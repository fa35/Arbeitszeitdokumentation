using System;
using System.Collections.Generic;
using Arbeitszeitdokumentation.Controller;
using NUnit.Framework;

namespace Arbeitszeitdokumentation.Tests
{
    [TestFixture]
    class TestSortedController
    {
        [Test]
        public void UnsortedList()
        {
            var unsortedWorkerList = new List<Worker> {new Worker("A", "X"), new Worker("C", "X"), new Worker("B", "X")};
            IController mokupController = new ControllerMockup(unsortedWorkerList);
            IController sortedController = new SortedController(mokupController);
            var actualResult = sortedController.GetWorkers();
            var expectedResult = new List<Worker> { new Worker("A", "X"), new Worker("B", "X"), new Worker("C", "X") };
            Assert.AreEqual(expectedResult[0].ToString(), actualResult[0].ToString());
            Assert.AreEqual(expectedResult[1].ToString(), actualResult[1].ToString());
            Assert.AreEqual(expectedResult[2].ToString(), actualResult[2].ToString());
        }

        [Test]
        public void SortedList()
        {
            var unsortedWorkerList = new List<Worker> { new Worker("A", "X"), new Worker("B", "X"), new Worker("C", "X") };
            IController mokupController = new ControllerMockup(unsortedWorkerList);
            IController sortedController = new SortedController(mokupController);
            var actualResult = sortedController.GetWorkers();
            var expectedResult = new List<Worker> { new Worker("A", "X"), new Worker("B", "X"), new Worker("C", "X") };
            Assert.AreEqual(expectedResult[0].ToString(), actualResult[0].ToString());
            Assert.AreEqual(expectedResult[1].ToString(), actualResult[1].ToString());
            Assert.AreEqual(expectedResult[2].ToString(), actualResult[2].ToString());
        }
    }

    class ControllerMockup : IController
    {
        public ControllerMockup(List<Worker> workerList)
        {
            WorkerList = workerList;
        }

        public List<Worker> WorkerList { get; set; }

        public void CreateWorker(Worker worker)
        {
            throw new NotImplementedException();
        }

        public List<Worker> GetWorkers()
        {
            return WorkerList;
        }
    }
}

using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Arbeitszeitdokumentation
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
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SortedList()
        {
            var unsortedWorkerList = new List<Worker> { new Worker("A", "X"), new Worker("B", "X"), new Worker("C", "X") };
            IController mokupController = new ControllerMockup(unsortedWorkerList);
            IController sortedController = new SortedController(mokupController);
            var actualResult = sortedController.GetWorkers();
            var expectedResult = new List<Worker> { new Worker("A", "X"), new Worker("B", "X"), new Worker("C", "X") };
            var actualFirstWorker = actualResult[0];
            var expectedFirstWorker = expectedResult[0];
            Assert.AreEqual(expectedFirstWorker, actualFirstWorker);
            Assert.AreEqual(expectedResult[0], actualResult[0]);
            Assert.AreEqual(expectedResult[1], actualResult[1]);
            Assert.AreEqual(expectedResult[2], actualResult[2]);
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

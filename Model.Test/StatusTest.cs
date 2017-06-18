using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using System.Collections.Generic;
using Model.Entities;
using System.Linq;

namespace Model.Test
{
    [TestClass]
    public class StatusTest
    {
        [TestMethod]
        public void GetAllStatusesTest()
        {
            var listStatus = Manager.Instance.GetAllStatuses();
            Assert.IsInstanceOfType(listStatus, typeof(List<Status>));
        }

        [TestMethod]
        public void GetStatusTest()
        {
            //Retrieve all statuses (to get the first to have is identifier)
            List<Status> listAllStatus = Manager.Instance.GetAllStatuses();
            if(listAllStatus.Count != 0)
            {
                Assert.IsInstanceOfType( Manager.Instance.GetStatus(listAllStatus.First().Id) , typeof(Status));
            }
        }

        [TestMethod]
        public void AddStatusTest()
        {
            Status status = new Status
            {
                Label = "labelTest"
            };
            Assert.AreEqual(1, Manager.Instance.AddStatus(status));
        }

        [TestMethod]
        public void UpdateStatusTest()
        {
            Status statusToTest = Manager.Instance.GetAllStatuses().FirstOrDefault();
            if(statusToTest != null)
            {
                statusToTest.Label = "newlabelfortest";
                Manager.Instance.UpdateStatus(statusToTest);
                Assert.AreEqual(statusToTest.Label, Manager.Instance.GetStatus(statusToTest.Id).Label);
            }
        }

        [TestMethod]
        public void DeleteStatusTest()
        {
            int numberOfStatusBeforeDeleteOne = Manager.Instance.GetAllStatuses().Count;
            Status statusToDelete = Manager.Instance.GetAllStatuses().FirstOrDefault();
            if (statusToDelete != null)
            {
                Manager.Instance.DeleteStatus(statusToDelete.Id);
                Assert.AreEqual(numberOfStatusBeforeDeleteOne - 1, Manager.Instance.GetAllStatuses().Count);
            }
        }
    }
}

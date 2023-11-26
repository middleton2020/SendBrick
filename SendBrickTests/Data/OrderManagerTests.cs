using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.SendBrick.Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrick.Library.Tests
{
    [TestClass()]
    public class OrderManagerTests
    {
        [TestMethod()]
        public void AddOneOrderTest()
        {
            OrderManager testManager = new OrderManager();

            TransferOrderData data1 = new TransferOrderData();
            int sequence1 = testManager.AddOrder(data1);

            Assert.AreEqual(0, sequence1);
        }
        [TestMethod()]
        public void AddMultipleOrdersTest()
        {
            OrderManager testManager = new OrderManager();

            TransferOrderData data1 = new TransferOrderData();
            int sequence1 = testManager.AddOrder(data1);

            TransferOrderData data2 = new TransferOrderData();
            int sequence2 = testManager.AddOrder(data2);

            TransferOrderData data3 = new TransferOrderData();
            int sequence3 = testManager.AddOrder(data3);

            Assert.AreEqual(0, sequence1);
            Assert.AreEqual(1, sequence2);
            Assert.AreEqual(2, sequence3);
        }
        [TestMethod()]
        public void GetOutsideRangeOrderTest()
        {
            string messageText = "";
            try
            {
                OrderManager testManager = new OrderManager();

                TransferOrderData data1 = new TransferOrderData();
                int sequence1 = testManager.AddOrder(data1);

                TransferOrderData data2 = new TransferOrderData();
                int sequence2 = testManager.AddOrder(data2);

                TransferOrderData data3 = new TransferOrderData();
                int sequence3 = testManager.AddOrder(data3);

                TransferOrderData testResult = (TransferOrderData)testManager.GetOrder(4);
            }
            catch (IndexOutOfRangeException e)
            {
                messageText = e.Message;
            }
            catch
            {
                throw;
            }

            Assert.AreEqual("There is no order with ID 4", messageText);
        }
        [TestMethod()]
        public void GetValidOrderTest()
        {
            OrderManager testManager = new OrderManager();

            TransferOrderData data1 = new TransferOrderData();
            int sequence1 = testManager.AddOrder(data1);

            TransferOrderData data2 = new TransferOrderData();
            int sequence2 = testManager.AddOrder(data2);

            TransferOrderData data3 = new TransferOrderData();
            int sequence3 = testManager.AddOrder(data3);

            Assert.IsNotNull(testManager.GetOrder(1));
        }
        [TestMethod()]
        public void GetInvalidOrderTest()
        {
            string messageText = "";
            try
            {
                OrderManager testManager = new OrderManager();

                TransferOrderData data1 = new TransferOrderData();
                int sequence1 = testManager.AddOrder(data1);

                //                TransferOrderData data2 = new TransferOrderData();
                //                int sequence2 = testManager.AddOrder(data2);
                int sequence2 = testManager.AddOrder(null);

                TransferOrderData data3 = new TransferOrderData();
                int sequence3 = testManager.AddOrder(data3);

                //           testManager.RemoveOrder(1);
                TransferOrderData testResult = (TransferOrderData)testManager.GetOrder(1);
            }
            catch (KeyNotFoundException e)
            {
                messageText = e.Message;
            }
            catch
            {
                throw;
            }

            Assert.AreEqual("No valid order with ID 1", messageText);
        }
        [TestMethod()]
        public void RemoveOrderTest()
        {
            try
            {
                OrderManager testManager = new OrderManager();

                TransferOrderData data1 = new TransferOrderData();
                int sequence1 = testManager.AddOrder(data1);

                TransferOrderData data2 = new TransferOrderData();
                int sequence2 = testManager.AddOrder(data2);

                TransferOrderData data3 = new TransferOrderData();
                int sequence3 = testManager.AddOrder(data3);

                testManager.RemoveOrder(1);
                TransferOrderData testResult = (TransferOrderData)testManager.GetOrder(1);
            }
            catch (KeyNotFoundException e)
            {
                Assert.IsTrue(true);
            }
            catch
            {
                throw;
            }
        }
    }
}
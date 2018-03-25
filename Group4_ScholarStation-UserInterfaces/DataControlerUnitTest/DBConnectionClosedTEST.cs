using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessControler;

namespace DataControlerUnitTest
{
    [TestClass]
    public class DBConnectionClosedTEST
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arange
            IConnection da = new ConnectionControler();
            
            //Act
            bool disconnected = da.closeConnection();

            //Assert
            Assert.IsTrue(disconnected);
        }
    }
}

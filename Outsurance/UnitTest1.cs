using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;


namespace Outsurance
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OpenFile()
        {
            //check if file exits
            string filepath = "C:\\Users\\baldw\\Pictures\\data.csv";
            Assert.AreEqual(true, File.Exists(filepath));
            
        }
        [TestMethod]
        public void ImportData()
        {

        }
        [TestMethod]
        public void SaveRecord()
        {

        }
        [TestMethod]
        public void SaveFiles()
        {

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AddressBookLinq;

namespace AddressBookTest
{
    [TestClass]
    public class UnitTest1
    {
        AddressBookManager addressBook;
        [TestInitialize]
        public void TestSetUp()
        {
            addressBook = new AddressBookManager();
        }
        [TestMethod]
        public void InsertionTest()
        {
            int expected = 1;
            int actual = addressBook.InsertIntoAddressBook(new ContactDetails());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EditCOntactTest()
        {
            int expected = 1;
            addressBook.AddAddresss();
            int actual = addressBook.EditContact(2, "shanthi", 87637489502);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteCOntactTest()
        {
            int expected = 1;
            addressBook.AddAddresss();
            int actual = addressBook.DeleteContact(2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RetrivalBaseonCityOrStateTest()
        {
            string expected = "shanthi mohan vetri ";
            addressBook.AddAddresss();
            string actual = addressBook.RetriveOnCityOrState("madurai", "TamilNadu");
            Assert.AreEqual(expected, actual);
        }

        //UC7-Counting the person based in city
        [TestMethod]
        public void CountBaseonCityOrStateTest()
        {
            string expected = "ymg 1 madurai 2 abc 1 chennai 1 xxx 1 ";
            addressBook.AddAddresss();
            string actual = addressBook.CountOfList();
            Assert.AreEqual(expected, actual);
        }

        //UC7-Sorting of list
        [TestMethod]
        public void CSortingOfList()
        {
            string expected = "mohan shanthi ";
            addressBook.AddAddresss();
            string actual = addressBook.SortingOfList("madurai");
            Assert.AreEqual(expected, actual);
        }
    }
}

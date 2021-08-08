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
            int actual = addressBook.EditContact(2, "tim", 87637489502);
            Assert.AreEqual(expected, actual);
        }
    }
}

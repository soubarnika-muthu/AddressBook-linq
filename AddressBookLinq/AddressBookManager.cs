using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    public class AddressBookManager
    {
        List<ContactDetails> address = new List<ContactDetails>();

        //adding item to the address book
        public List<ContactDetails> AddAddresss()
        {
            address.Add(new ContactDetails { personId = 1,  firstName = "sou", lastName = "muthu", address = "NH road", state = "kerala", city = "ymg", zipCode = 869542, phoneNumber = 8546321556, emailAddress = "sou@gmail.com" });
            address.Add(new ContactDetails { personId = 2,  firstName = "shanthi", lastName = "venkat", address = "mgm coloney", state = "TamilNadu", city = "madurai", zipCode = 568942, phoneNumber = 8542631564, emailAddress = "shanthi@gmail.com" });
            address.Add(new ContactDetails { personId = 3,  firstName = "vijay", lastName = "kumar", address = "vng road", state = "Kerala", city = "abc", zipCode = 845126, phoneNumber = 5423698542, emailAddress = "vk@gmail.com" });
            address.Add(new ContactDetails { personId = 6,  firstName = "mohan", lastName = "prasad", address = "hall road", state = "TamilNadu", city = "madurai", zipCode = 956152, phoneNumber = 9856123457, emailAddress = "mohan.p@gmail.com" });
            address.Add(new ContactDetails { personId = 4,  firstName = "vetri", lastName = "maran", address = "yng coloney", state = "TamilNadu", city = "chennai", zipCode = 758462, phoneNumber = 7856954236, emailAddress = "maran@gmail.com" });
            address.Add(new ContactDetails { personId = 5,  firstName = "geminika", lastName = "muthu", address = "mgr nagar", state = "kerala", city = "xxx", zipCode = 869542, phoneNumber = 6548597235, emailAddress = "gemmuthu@gmail.com" });
            return address;
        }

        //UC2-Insert Into AddressBook
        public int InsertIntoAddressBook(ContactDetails contact)
        {
            contact.personId = 7;
            contact.firstName = "dev";
            contact.lastName = "dixit";
            contact.address = "anna nagar";
            contact.city = "madurai";
            contact.state = "tamil nadu";
            contact.zipCode = 845236;
            contact.phoneNumber = 7856423695;
            contact.emailAddress = "ghk@gmail.com";
            AddAddresss();
            address.Add(contact);
            return 1;
        }

        //UC3-Edit contact
        public int EditContact(int personid, string firstName, long phoneNumber)
        {
            ContactDetails contact = (from add in address where add.personId == personid && add.firstName.Equals(firstName) select add).First();
            if (contact == null)
            {
                return 0;
            }
            else
            {
                contact.phoneNumber = phoneNumber;
                return 1;
            }
        }
    }
}

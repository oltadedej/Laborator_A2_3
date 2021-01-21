using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laborator_A2_3.Laborator3.Domain
{
    public class Configuration
    {
        public List<PhoneBook> phoneBooks { get; set; } = new List<PhoneBook>(); // default set

        public Configuration()
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.IdPhoneBook = 1;
            phoneBook.PhoneBookPersonName = "Test1";
            phoneBook.PhoneNumber = "5487444522";
            phoneBook.PhoneType = 1;
            phoneBooks.Add(phoneBook);
            phoneBook = new PhoneBook();
            phoneBook.IdPhoneBook = 2;
            phoneBook.PhoneBookPersonName = "Test2";
            phoneBook.PhoneNumber = "8745126547";
            phoneBook.PhoneType = 2;
            phoneBooks.Add(phoneBook);
        }
    }
}
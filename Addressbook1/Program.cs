using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook1
{
    public class AddressBook
    {
        static void Main(string[] args)
        {
           
           AddressClass1 addressClass1 = new AddressClass1();
            Console.WriteLine("Please select a option\n1 : Add to contacts");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("please  enter  address book name");
                    string Addressbookname = Console.ReadLine();
                    Console.WriteLine("How many contacts what to add");
                    int NumofContact = Convert.ToInt32(Console.ReadLine());
                    addressClass1.AddContacts(Addressbookname, NumofContact);
                        break;
                 case 2:
                    Console.WriteLine("Displaying Addressbook");
                    break;
                case 3:
                    Console.WriteLine("please  enter  address book name");
                    string AddressbookR = Console.ReadLine();
                    Console.WriteLine("How many contacts do you want to delete");
                    int NumofContactremove = Convert.ToInt32(Console.ReadLine());
                    addressClass1.DeleteContact(AddressbookR, NumofContactremove);
                    break;


                case 4:
                    break;

            }
            Console.ReadLine();
        }



        /*
          { name: "Person 1", address: "Address 1", contact: "0123456789", email: "123@gmail.com"},

        { name: "Person 2", address: "Address 2", contact: "4536782947", email: "1234@gmail.com"},

        { name: "Person 3", address: "Address 3", contact: "5647839244", email: "122345gmail.com"},

        { name: "Person 4", address: "Address 4", contact: "43890128743", email: "123456e@gmail.com"},

         { name: "Person 5", address: "Address 5", contact: "3456789012", email: "1234666@gmail.com"},
        
        */
    }
}

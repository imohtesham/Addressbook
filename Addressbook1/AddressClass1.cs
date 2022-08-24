using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook1
{
    public class AddressClass1
    {
        List<Person> listOfContacts = new List<Person>();
        Dictionary<string, List<Person>> listOfbooks = new Dictionary<string, List<Person>>();
       //Dictionary<string, List<Person>> remove = new Dictionary<string, List<Person>>();

        public void AddContacts(string Addressbookname, int NumofContacts)
        {
           Person person = new Person();


            int count = 0;

            while(true)
            { 
               
                Console.Write("please Enter first name : ");
                person.FirstName = Console.ReadLine();

                Console.Write("please Enter last name : ");
                person.LastName = Console.ReadLine();

                Console.Write("please Enter Email Address : ");
                person.Email= Console.ReadLine();

                Console.Write("please Enter Address : ");
                person.Address = Console.ReadLine();

                Console.Write("please Enter Zip code :");
                person.ZipCode = Convert.ToInt32(Console.ReadLine());

                Console.Write("please Enter Phone number code : ");
                person.Phonenumber  = Convert.ToInt32(Console.ReadLine());

                Console.Write("please Enter City name : ");
                person.Cityname = Console.ReadLine();

                Console.Write("please Enter state : ");
                person.state = Console.ReadLine();

                listOfContacts.Add(person);
                count++;
                if(count== NumofContacts)
                {
                    listOfbooks.Add(Addressbookname, listOfContacts);
                    break;
                }
               // listOfContacts.Remove(person);
               /// count++;
                //if (count == NumofContactremove)
                //{
                  ///  remove.Remove(AddressbookR);
                  ///  break;s
                

            }

        }
    }
}


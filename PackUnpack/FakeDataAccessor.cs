using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackUnpack
{
    public class FakeDataAccessor
    {
        //----------------------------------------------------------------------
        public List<string> fileItems()
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\mingo\source\repos\PackUnpack\PackUnpack\people.csv"));
            List<string> listA = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                listA.Add(values[0]);

                foreach (var coloumn1 in listA)
                {
                    Console.WriteLine("File item:" + coloumn1);
                }

            }
            return listA;
        }
        //----------------------------------------------------------------------
        // A fake data store. This is static so that the same list
        // is used accross all instances of FakeDataAccessor
        static List<Person> personStore = new List<Person>()
            {
                new Person("username_1", "firstname_1", "lastname_1", "password_1"),
                new Person("username_2", "firstname_2", "lastname_2", "password_2"),
                new Person("username_3", "firstname_3", "lastname_3", "password_3"),
                new Person("username_4", "firstname_4", "lastname_4", "password_4"),
                new Person("username_5", "firstname_5", "lastname_5", "password_5"),
                new Person("username_6", "firstname_6", "lastname_6", "password_6"),
                new Person("username_7", "firstname_7", "lastname_7", "password_7")

            };
        public List<Person> getPersons()
        {

            // let us return some fake data
            return personStore;



        }

        public void changePassword(string username, string currentPassword, string targetPassword)
        {

         
            List<Person> persons = getPersons();

            foreach (Person person in persons)
            {
                if (person.Username == username)
                {
                    if (person.Password == currentPassword)
                    {
                        person.Password = targetPassword;
                        break;
                    }
                    else
                    {
                        // never print to console in model classes. this is just for our own
                        // debug
                        Console.WriteLine("Password on file was not the same");
                    }
                }
            }

            // so if you're converting this to work with a text file
            // 1. Get persons from the file into a List
            // 2. Change the password in the list provided the username and current password are correct.
            // 3. Overwrite the file with the new list!
            // 4. You're done!
        }
        public void authenticate() 
        {
            StreamReader reading = File.OpenText(@"C:\Users\mingo\source\repos\PackUnpack\PackUnpack\people.csv");
            List<Person> persons = getPersons();
            string str;
            while ((str = reading.ReadLine()) != null)
            {
                if (str.Contains("password"))
                {
                    StreamWriter write = new StreamWriter(" new password");
                }
            }
        }
    }
}

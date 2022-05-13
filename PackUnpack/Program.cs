using System;
using System.Collections.Generic;

namespace PackUnpack
{
    class Program
    {
        static void Main(string[] args)
        {

            FakeDataAccessor fd = new FakeDataAccessor();

            List<Person> persons = fd.getPersons();

            PrintPersons(persons);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Changing the password for username_2");

            PersonManager personManager = new PersonManager();
            personManager.changePassword(username:"username_7", currentPassword: "password_7", targetPassword:"francis");

            Console.WriteLine("After the password change");
            List<Person> newPersonsList = fd.getPersons();
            PrintPersons(newPersonsList);
        }

        public static void PrintPersons(List<Person> persons)
        {
            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }

        }
    }
}

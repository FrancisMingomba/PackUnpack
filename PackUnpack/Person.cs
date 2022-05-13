using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackUnpack
{
    public class Person
    {
        public Person(string username, string firstName, string lastName, string password)
        {
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
        }
        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public override string ToString()
        {
            return $"Username: [{Username}] First Name: [{FirstName}], LastName: [{LastName}], Password: [{Password}]";
        }
    }
}

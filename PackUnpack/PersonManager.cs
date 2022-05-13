using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackUnpack
{
    public class PersonManager
    {
        public void changePassword(string username, string currentPassword, string targetPassword)
        {
            new FakeDataAccessor().changePassword(username, currentPassword, targetPassword);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEststate.Models
{
    public class RegisteredUser : User
    {
        int phoneNumber;

        public RegisteredUser(int i, string n, string e, string p, int num)
        {
            id = i;
            name = n;
            email = e;
            password = p;
            phoneNumber = num;
        }
    }
}

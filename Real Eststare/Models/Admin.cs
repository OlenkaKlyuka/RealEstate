using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEststate.Models
{
    public class Admin : User
    {
        public Admin(int i, string n, string e, string p)
        {
            name = n;
            email = e;
            password = p;
            id = i;
        }
    }
}

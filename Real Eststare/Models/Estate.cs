using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEststate.Models
{
    public class Estate
    {
        int id;
        string adress;
        int price;
        List<string> images;
        User owner;
    }
}

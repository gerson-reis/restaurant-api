using System;
using System.Collections.Generic;
using System.Text;

namespace restaurant_domain
{
    public class Menu
    {
        public Restaurant Restaurant { get; set; }
        public List<Plate> Plates { get; set; }
    }
}

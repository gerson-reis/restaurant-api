using restaurant_domain;
using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Domain;

namespace Restaurant.Application.Menu

{
    public class Menu
    {
        public Establishment Restaurant { get; set; }
        public List<Plate> Plates { get; set; }
    }
}

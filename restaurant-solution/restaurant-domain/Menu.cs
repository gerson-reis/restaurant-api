﻿using Restaurant.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace restaurant_domain
{
    public class Menu
    {
        public Establishment Restaurant { get; set; }
        public List<Plate> Plates { get; set; }
    }
}

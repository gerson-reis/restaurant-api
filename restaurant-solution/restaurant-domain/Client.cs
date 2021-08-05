using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Domain
{
    public class Client : BaseEntity
    {
        private Client()
        {

        }

        public Client(string name, string nIF)
        {
            Name = name;
            NIF = nIF;
        }

        public string Name { get; private set; }
        public string NIF { get; private set; }
    }
}

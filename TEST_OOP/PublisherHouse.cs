using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TEST_OOP
{
    internal class PublisherHouse
    {
        public int Id { get; set;  }
        public string Name { get; set; }
        public string Adress { get; set; }

        public PublisherHouse(int id, string name, string adress)
        {
            Id = id;
            Name = name;
            Adress = adress;
        }
    }
}

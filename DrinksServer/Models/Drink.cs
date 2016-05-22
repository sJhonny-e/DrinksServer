using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrinksServer.Models
{
    public class Drink
    {
        public string Name { get; private set; }

        public Drink(string name)
        {
            Name = name;
        }
    }
}
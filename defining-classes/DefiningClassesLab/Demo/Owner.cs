using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Owner
    {
        public string Name { get; set; }

        public List<Cat> Cats { get; set; } = new List<Cat>();
    }
}

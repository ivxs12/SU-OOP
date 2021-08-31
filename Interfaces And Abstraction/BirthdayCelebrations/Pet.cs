using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    class Pet : IPet
    {
        public string Name { get; set; }
        public string Birthday { get; set; }

        public Pet(string name, string date)
        {
            this.Name = name;
            this.Birthday = date;
        }
    }
}

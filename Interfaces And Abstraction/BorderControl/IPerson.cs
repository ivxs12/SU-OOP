using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; }
        public string Id { get; }
    }
}

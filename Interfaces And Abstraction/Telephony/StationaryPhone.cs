using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    class StationaryPhone : IStationable
    {
        public void Call(string number)
        {
            if (number.Any(x => !char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Dialing... {number}");
            }
        }
    }
}

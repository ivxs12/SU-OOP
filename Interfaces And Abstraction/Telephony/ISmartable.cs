using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ISmartable
    {
        void Call(string number);
        void Browse(string url);
    }
}

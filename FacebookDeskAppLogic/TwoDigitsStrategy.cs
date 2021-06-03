using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookDeskAppLogic
{
    class TwoDigitsStrategy : IStrategy
    {
        public bool TestNumber(int i_Num)
        {
            return i_Num >= 10 && i_Num < 100;
        }
    }
}

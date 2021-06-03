using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookDeskAppLogic
{
    class AboveTwoDigitsStrategy : IStrategy
    {
        public bool TestNumber(int i_Num)
        {
            return i_Num >= 100;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestAndDebug
{
    public class Cumple
    {
        public static bool IsValid(string bday)
        {
            if (bday.Length == 8)
            {
                return true;
            }else{return false;}
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFootZalApp
{
    public static class Utilities
    {
        public static bool MyEmpty(string[] myarr, string text)
        {
            foreach (var arrr in myarr)
            {
                if (arrr == text)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

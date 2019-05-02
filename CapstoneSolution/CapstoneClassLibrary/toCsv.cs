using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneClassLibrary
{
    public static class ToCsv
    {
        //Used to create a CSV from a list
        public static string convert(this List<string> itemList)
        {
            return string.Join(",", itemList);
        }
    }
}

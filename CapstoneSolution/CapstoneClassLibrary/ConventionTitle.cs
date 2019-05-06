using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneClassLibrary
{
    // class for convention general information that directly corresponds to the ConventionTitles table in the database
    public class ConventionTitle
    {
        public int conventionTitleID { get; set; }
        public string conventionTitleName { get; set; }
        public string conventionTitleTitle { get; set; }
        public string conventionTitleSubtitle { get; set; }
        public string conventionTitleDescription { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject
{
    class ProgramManager
    {
        // singleton
        private static ProgramManager _instance;

        private ProgramManager()
        {

        }

        public static ProgramManager instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProgramManager();
                }

                return _instance;
            }
        }

        // to do: database connection method
    }
}
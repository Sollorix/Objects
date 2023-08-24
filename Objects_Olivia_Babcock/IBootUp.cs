using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Olivia_Babcock
{
    internal interface IBootUp
    {   
        // Sets parameter values
        public bool IsOn { get; set; }

        // Calls PowerOnOff method
        public void PowerOnOff();
    }
}

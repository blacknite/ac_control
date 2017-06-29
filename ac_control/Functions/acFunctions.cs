using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ac_control.Models;

namespace ac_control.Functions
{
    public class acFunctions
    {
        private ACunit turnOnUnit(ACunit unit)
        {
            string currentvalue = fileFunctions.getGPIOstatus(unit.gpio_no);
            if (currentvalue == "off")
                fileFunctions.setGPIOstatus(unit.gpio_no, "on");
            unit.gpio_status = fileFunctions.getGPIOstatus(unit.gpio_no);
            return unit;
        }
        
        private ACunit turnOffUnit(ACunit unit)
        {
            string currentvalue = fileFunctions.getGPIOstatus(unit.gpio_no);
            if (currentvalue == "on")
                fileFunctions.setGPIOstatus(unit.gpio_no, "off");
            unit.gpio_status = fileFunctions.getGPIOstatus(unit.gpio_no);
            return unit;

        }

        //private void 
    }
}

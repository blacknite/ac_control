using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ac_control.Models
{
    public class ACunit
    {
        public string unit_number { get; set; }
        public string unit_name { get; set; }
        public string gpio_no { get; set; }
        public string gpio_status { get; set; }

        public ACunit()
        { }

        public ACunit(string unit_number, string unit_name, string gpio_no)
        {
            this.unit_name = unit_name;
            this.unit_number = unit_number;
            this.gpio_no = gpio_no;
        }
    }
}

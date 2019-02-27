using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab1 {
    public class NickelMetalHydrideBattery : BatteryAttribute {
        public override int Capacity { get; set; }
        public override string ToString() {
            return "Nickel Metal Hydride Battery";
        }
    }
}

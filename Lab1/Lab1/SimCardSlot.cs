using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab1 {
    public class SimCardSlot : SlotAttribute {
        public override int Height { get; set; }
        public override int Width { get; set; }
        public override string ToString() {
            return "SimCard Slot";
        }
    }
}

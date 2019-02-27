using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab1 {
    public class PhisicalKeyboard : KeyboardAttribute {
        public override List<Button> Buttons { get; set; }

        public override void Push(IInput input) {
        }

        public override string ToString() {
            return "Phisical Keyboard";
        }
    }
}

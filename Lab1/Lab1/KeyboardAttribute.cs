using System.Collections.Generic;

namespace SimCorp.IMS.Lab1 {
    public abstract class KeyboardAttribute {
        private List<Button> vButtons;
        public abstract List<Button> Buttons { get; set; }
        public abstract void Push(IInput input);
    }
}
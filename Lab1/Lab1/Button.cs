using System.Collections.Generic;

namespace SimCorp.IMS.Lab1 {
    public class Button {
        private List<char> vValues;

        public List<char> Values {
            get {
                return vValues;
            }
            set {
                vValues = value;
            }
        }
    }
}
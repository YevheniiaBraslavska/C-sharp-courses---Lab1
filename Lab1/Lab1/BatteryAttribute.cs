namespace SimCorp.IMS.Lab1 {
    public abstract class BatteryAttribute {
        private int vCapacity;
        public abstract int Capacity { get; set; }

        public override string ToString() {
            return "Battery Basic";
        }
    }
}
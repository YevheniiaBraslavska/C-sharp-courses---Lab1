namespace SimCorp.IMS.Lab1 {
    public abstract class ScreenAttribute {
        private int vHeight;
        public abstract int Height { get; set; }
        private int vWidth;
        public abstract int Width { get; set; }
        private int vPixels;
        public abstract int Pixels { get; set; }
        public abstract void Show(IScreenImage screenImage);
    }
}
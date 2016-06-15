namespace MobilePhone
{
    public class Display
    {
        private double displaySize;
        private int displayColor;

        public double DisplaySize
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                this.displaySize = value;
            }
        }
        public int DisplayColor
        {
            get
            {
                return this.displayColor;
            }
            set
            {
                this.displayColor = value;
            }
        }
        public Display(double displaySize,int displayColor)
        { 
            this.DisplaySize = displaySize;
            this.DisplayColor = displayColor;
        }
    }
}

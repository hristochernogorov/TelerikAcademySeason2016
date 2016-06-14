namespace MobilePhone
{
    public class Battery
    {
        public string batteryModel;
        public int idleHours;
        public int talkHours;
        private BatteryType LiIon;

        public Battery(BatteryType type)
        {
            this.LiIon = type;
        }

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                this.batteryModel = value;
            }
        }
        public int IdleHours
        {
            get
            {
                return this.idleHours;
            }
            set
            {
                this.idleHours = value;
            }
        }
        public int TalkHours
        {
            get
            {
                return this.talkHours;
            }
            set
            {
                this.talkHours = value;
            }
        }

    }
}

namespace MobilePhone
{
    using System.Text;

    public class Battery
    {
        private string batteryModel;
        private int idleHours;
        private int talkHours;
        private BatteryType typeBattery;
        private BatteryType liIon;
        private BatteryType liPol;

        public Battery(BatteryType liIon,int idleHours,int talkHours)
        {
            this.liIon = liIon;
            this.IdleHours = idleHours;
            this.TalkHours = talkHours;
        }

        public Battery(BatteryType liPol)
        {
            this.liPol = liPol;
        }

        public BatteryType TypeBattery
        {
            get
            {
                return this.typeBattery;
            }
            set
            {
                typeBattery = value;
            }
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
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.BatteryModel == null)
            {
                result.Append("No Battery");
            }
            else
            {
                result.Append(string.Format("Model: {0}", this.BatteryModel));
                result.Append(string.Format("Battery type: {0}", this.TypeBattery));
                result.Append(string.Format("Hours Idle: {0}", this.IdleHours));
                result.Append(string.Format("Hours Talk: {0}", this.TalkHours));
            }
            return base.ToString();
        }

    }
}

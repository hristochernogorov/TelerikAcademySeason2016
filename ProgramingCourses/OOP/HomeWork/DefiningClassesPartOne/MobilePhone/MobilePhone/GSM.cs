namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        public static GSM IPhone4S = new GSM(
            "IPhone4S",
            "Apple",
            1000,
            "Pesho",
            new Display(4.5, 24000000),
            new Battery(BatteryType.LiPol));

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
           
        }
        public GSM(string model, string manufacturer, decimal price) : this(model, manufacturer)
        {
            this.Price = price;
        }
        public GSM(string model, string manufacturer, decimal price, string owner) : this(model,manufacturer,price)
        {
            this.Owner = owner;
        }
         public GSM(string model, string manufacturer,decimal price,string owner, Display display) : this(model,manufacturer,price,owner)
        {
            this.Display = display;
        }
        public GSM(string model, string manufacturer, decimal price,string owner,Display display, Battery battery)
        {
            this.Batery = battery;
        }

 
        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public Battery Batery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.CallHistory;
            }
           
        }


        public void AddDeleteCalls(Call call)
        {
            this.CallHistory.Remove(call);
        }
        public void DeleteCallHistory()
        {
            this.CallHistory.Clear();
        }
        public decimal CalculatePriceOfCallHistory(decimal callPrice)
        {
            ulong duration = 0;
            foreach (var call in this.CallHistory)
            {
                duration += (ulong)call.CallDuration;
            }
            callPrice *= (decimal)(duration / 60); 
            return callPrice;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Model: {0}", this.Model));
            sb.AppendLine(string.Format("Manufacturer: {0}", this.Manufacturer));
            sb.AppendLine(string.Format("Price: {0}", this.Price));
            sb.AppendLine(string.Format("Owner: {0}", this.Owner));
            sb.AppendLine(string.Format("Batery: {0}", this.Batery));
            sb.AppendLine(string.Format("Display: {0}", this.Display));

            return sb.ToString();
        }
    }
}

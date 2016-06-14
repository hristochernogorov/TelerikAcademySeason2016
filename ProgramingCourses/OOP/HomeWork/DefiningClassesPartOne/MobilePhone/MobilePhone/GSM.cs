namespace MobilePhone
{
    using System.Collections.Generic;

    public class GSM
    {
        public static GSM IPhone4S = new GSM(
            "IPhone4S",
            "Apple",
            1000,
            "Pesho",   
            new Display(4.5,24000000),
            new Battery(BatteryType.LiIon));

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
            if (display == null || Batery == null || Owner == null || Price.ToString() == null)
            {
                this.Display = null;
                this.Batery = null;
                this.Owner = null;
                this.Price = 0.00M;

            }


        }
        public GSM(string model, string manufacturer, decimal price, string owner,Display display, Battery battery)
        {
            this.Price = price;
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = owner;
            this.Batery = battery;
            this.Display = display;

        }
        public string AllInformation()
        {
            var info = new List<string>();



            return info.ToString();
        }
        public void AddDeleteCalls()
        {

        }
        public void DeleteCallHistory()
        {

        }
        public decimal CalculatePriceOfCallHistory(decimal callPrice)
        {

            return callPrice;
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
            set
            {
                this.CallHistory = value;
            }
        }


    }
}

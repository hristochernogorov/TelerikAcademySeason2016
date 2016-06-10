namespace MobilePhone
{
    using System.Collections.Generic;

    public class GSM
    {
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
                
            }


        }
        public GSM(decimal price,string model,string manufacturer, string owner, Battery battery, Display display)
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


    }
}

namespace BankSystem
{
    public class CompaniesClients
    {
        private string companyName;
        private int companyID;

        public int CompanyID {

            get
            {
               return this.companyID = CompanyID;
            }
            private set
            {
                this.CompanyID = value;
            }
        }
        public string CompanyName {

            get
            {
               return this.companyName = CompanyName;
            }
            private set
            {
                this.CompanyName= value;
            }
        }




    }
}

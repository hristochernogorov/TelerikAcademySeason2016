namespace MobilePhone
{
    
    public class MobilePhoneMain
    {
        

        public static void Main()
        {
            GSM newPhone = new GSM("P9", "HUAWEI");
            newPhone.Owner = "Gosho";
            newPhone.Price = 200.70M;
            newPhone.Display = new Display(4.5,256000);
            newPhone.Batery = new Battery();
            






        }
    }
}

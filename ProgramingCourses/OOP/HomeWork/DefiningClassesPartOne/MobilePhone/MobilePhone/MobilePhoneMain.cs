namespace MobilePhone
{ 
    public class MobilePhoneMain
    {
        public static void Main()
        {
            GSM newPhone = new GSM("P9", "HUAWEI");
            newPhone.Owner = "Gosho";
            newPhone.Price = 200.70M;
            newPhone.Display = new Display(4.5, 256000);
            newPhone.Batery = new Battery(BatteryType.LiIon, 32, 32);
            GSM anotherPhone = new GSM("P8", "HUAWEI");
            anotherPhone.Owner = "Pesho";
            anotherPhone.Display = new Display(4.3, 16000000);
            anotherPhone.Batery = new Battery(BatteryType.NiCd, 43, 43);
        }
    }
}

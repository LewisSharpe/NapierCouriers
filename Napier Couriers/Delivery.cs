namespace Napier_Couriers
{
    public class Delivery : Visit
    {
        public Delivery() //constructor methods
        {
        }

        //PICK UP NAME: Get and set method:
        private string myDeliveryName;
        public string DeliveryName //property for manipulating delivery name.
        {
            get { return myDeliveryName; }
            set { myDeliveryName = value; }
        }

        //PICK UP ADDRESS: Get and set method:
        private string myDeliveryAddress;
        public string DeliveryAddress //property for manipulating delivery address.
        {
            get { return myDeliveryAddress; }
            set { myDeliveryAddress = value; }
        }
    }
}
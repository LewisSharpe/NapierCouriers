namespace Napier_Couriers
{
    public class PickUp : Visit
    {
        public PickUp() //constructor methods
        {
        }

        //PICK UP NAME: Get and set method:
        private string myPickUpName;
        public string PickUpName //property for manipulating pick up name.
        {
            get { return myPickUpName; }
            set { myPickUpName = value; }
        }

        //PICK UP ADDRESS: Get and set method:
        private string myPickUpAddress;
        public string PickUpAddress //property for manipulating pick up address.
        {
            get { return myPickUpAddress; }
            set { myPickUpAddress = value; }
        }
    }
}
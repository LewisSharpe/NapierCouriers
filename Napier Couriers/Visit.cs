namespace Napier_Couriers
{
    public class Visit
    {
        public Visit() //constructor methods
        {
        }
        //CUSTOMER FORENAME: Get and set method:
        private string myCustomerForename;
        public string CustomerForename //property for manipulating forename.
        {
            get { return myCustomerForename; }
            set { myCustomerForename = value; }
        }
        // CUSTOMER SURNAME: Get and set method:
        private string myCustomerSurname;
        public string CustomerSurname //property for manipulating surname.
        {
            get { return myCustomerSurname; }
            set { myCustomerSurname = value; }
        }
        //CUSTOMER ADDRESS: Get and Set method:
        private string myCustomerAddress;
        public string CustomerAddress //property for manipulating customer.
        {
            get { return myCustomerAddress; }
            set { myCustomerAddress = value; }
        }
        //ARRIVAL TIME: Get and set method:
        private int myArrivalTime;
        public int ArrivalTime//property for manipulating arrival time.
        {
            get { return myArrivalTime; }
            set { myArrivalTime = value; }
        }
    }
}


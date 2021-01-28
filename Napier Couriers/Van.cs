namespace Napier_Couriers
{
    public class Van
    {
        public Van() //constructor methods
        {
        }
        //VAN NUMBER: Get and set method:
        private string myVanNumber;
        public string VanNumber //property for manipulating van number.
        {
            get { return myVanNumber; }
            set { myVanNumber = value; }
        }
    }
}
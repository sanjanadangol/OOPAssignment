namespace OOPS
{
    public class Customer
    {// Member Variables
        public int CustID;
        public string Name;
        public string Address;

    //constuctor for initializing fields
        public Customer()
        {
            CustID = 1101;
            Name = "Tom";
            Address = "USA";
        }

    //method for displaying customer records (functionality)
        public void displayData()
        {
            Console.WriteLine("Customer=" + CustID);
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Address=" + Address);
        }
    // Code for entry point
    }
}
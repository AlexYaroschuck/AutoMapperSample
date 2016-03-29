
namespace AutoMapperTests.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Item { get; set; }
        public int Amount { get; set; }
        public string MerchandFName { get; set; }
        public string MechandLName { get; set; }
        public int CCNumber { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int CCLastFour { get; set; }

        
        public override string ToString()
        {
            return "FirstName: " + FirstName + "\n" + "LastName: " + LastName + "\nItem: " + Item + "\nAmount: " + Amount
                   + "\nMechandLName: " + MechandLName + "\nMerchandFName: " + MerchandFName
                   + "\nCCNumber: " + CCNumber + "\nCCLastFour: " + CCLastFour + "\nAddress: " + Address
                   + "\nAge: " + Age + "\nEmail: " + Email;
        }
    }
}

using System;
using AutoMapper;
using AutoMapperTests.Models;

namespace AutoMapperTests
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMapperConfig.RegisterMapps();


            var merchand1 = new Merchand()
            {
                LastName = "MerchandLastName",
                FirstName = "MerchandFirstName",
                Amount = 100,
                ItemName = "MerchandItem"
            };

            var billingInfo = new BillingInfo()
            {
                City = "NY",
                Country = "US",
                Street = "street 1",
                CreditCardNumber = 123456789,
                LastFour = 6789
            };

            var userFrom = new UserForm()
            {
                Age = 25,
                Email = "example@gmail.com",
                Login = "Login",
                Password = "Password",
                Name = "UserFirst" + " " + "UserLast"
            };

            try
            {
                var custumer = Mapper.Map<Merchand, Customer>(merchand1);
                Mapper.Map(billingInfo, custumer);
                Mapper.Map(userFrom, custumer);

                var userForm = Mapper.Map<Customer, UserForm>(custumer);
                Console.WriteLine(custumer.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.ReadLine();
        }
    }
}

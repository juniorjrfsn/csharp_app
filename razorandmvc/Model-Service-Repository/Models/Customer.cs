using System;

namespace Model_Service_Repository.Models
{
    public class Customer
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string ShippingAddress { get; set; }

        public DateTime CreatedAt
        {
            get
            {
                return GioId.GetCreationDate(Id);
            }
        }
    }
}
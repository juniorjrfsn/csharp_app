using System;

namespace Model_Service_Repository.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt
        {
            get
            {
                return GioId.GetCreationDate(Id);
            }
        }
    }
}
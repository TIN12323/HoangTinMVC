using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models.Entities
{
    public class Customer
    {
        [Key]
        public string CustomerId {get; set;}
        public string FullName { get; set; }
        public string  Address { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}


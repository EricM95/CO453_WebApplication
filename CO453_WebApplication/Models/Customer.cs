using System.ComponentModel.DataAnnotations;

namespace CO453_WebApplication.Models
{
    /// <summary>
    /// This class will collect data
    /// from the customer details page
    /// </summary>
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; }

        [Required]
        public string Address { get; set; }
    }
}

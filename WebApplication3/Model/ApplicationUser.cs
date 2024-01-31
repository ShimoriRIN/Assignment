using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Credit Card No is required")]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "Credit Card No must be a 16-digit number")]
        public string CreditCardNumber { get; set; }

        [Required(ErrorMessage = "Mobile No is required")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "Mobile No must be a 8-digit number")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Billing Address is required")]
        public string BillingAddress { get; set; }

        [Required(ErrorMessage = "Shipping Address is required")]
        [RegularExpression(@"^[a-zA-Z0-9\s.,#-]+$", ErrorMessage = "Shipping Address can contain letters, numbers, spaces, and special characters (.,#-)")]
        public string ShippingAddress { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email address")]
        [EmailAddress(ErrorMessage = "Invalid Email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Photo is required")]
        [RegularExpression(@"^.+\.jpg$", ErrorMessage = "Photo must be in .JPG format")]
        public string Photo { get; set; }
    }
}

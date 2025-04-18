using SocialAssistInfoSystem.Client.Data.Enum;
using System.ComponentModel.DataAnnotations;
using static SocialAssistInfoSystem.Client.Pages.Application;

namespace SocialAssistInfoSystem.Client.Data
{
    public class ApplicationModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public DateTime? DOB { get; set; }

        public Gender Gender { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public Scheme Scheme { get; set; }

        public AddressModel Address { get; set; } = new AddressModel();

        //public string Email { get; set; }
        public string PassportNo { get; set; } = "4012 8888 8888 1881";

        public string AnyOtherScheme { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Enter a valid 10-digit number")]
        public string PhoneNumber { get; set; }



        //public List<OrderDetailsModel> OrderDetails = new List<OrderDetailsModel>()
        //{
        //    new OrderDetailsModel()
        //        {
        //            Description = "Perform Work order 1",
        //            Offer = 100
        //        },
        //    new OrderDetailsModel()
        //};
    }
}

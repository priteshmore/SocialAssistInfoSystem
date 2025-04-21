using SocialAssistInfoSystem.Client.Data.Dto;
using SocialAssistInfoSystem.Client.Data.Enum;

namespace SocialAssistInfoSystem.Client.Data.ViewModel
{
    public class ApplicationVM
    {

        public int Id { get; set; }

        public ApplicationStatus Status { get; set; }

        public ProfileVm Profile { get; set; }

        public AddressVM Address { get; set; }

        public SchemeVM Scheme { get; set; }

        public ApplicationVM() 
        {
            Profile = new ProfileVm();
            Address = new AddressVM();
            Scheme = new SchemeVM();
        }

#if false
        #region Old
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public DateTime? DOB { get; set; }

        public Gender Gender { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public SchemeOption Scheme { get; set; }

        public AddressModel Address { get; set; } = new AddressModel();

        //public string Email { get; set; }
        public string PassportNo { get; set; } = "4012 8888 8888 1881";

        public string AnyOtherScheme { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Enter a valid 10-digit number")]
        public string PhoneNumber { get; set; }

        #endregion

        //public List<OrderDetailsModel> OrderDetails = new List<OrderDetailsModel>()
        //{
        //    new OrderDetailsModel()
        //        {
        //            Description = "Perform Work order 1",
        //            Offer = 100
        //        },
        //    new OrderDetailsModel()
        //};
#endif
    }
}

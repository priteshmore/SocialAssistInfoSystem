using SocialAssistInfoSystem.Client.Data.Enum;
using System.Text.Json.Serialization;

namespace SocialAssistInfoSystem.Client.Data.ViewModel
{
    public class ProfileVm
    {
        public int Id { get; set; }

        //public int ApplicationId { get; set; }

        //[JsonIgnore]
        //public Application Application { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime? DOB { get; set; }

        public Gender Gender { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public string PassportNo { get; set; }

        public string PhoneNumber { get; set; }

    }
}

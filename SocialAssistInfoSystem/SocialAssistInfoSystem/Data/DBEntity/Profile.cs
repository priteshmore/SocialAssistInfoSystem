using System.Text.Json.Serialization;

namespace SocialAssistInfoSystem.Data.DBEntity
{
    public class Profile
    {
        public int Id { get; set; }

        public int ApplicationId { get; set; }

        [JsonIgnore]
        public Application Application { get; set; }
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime? DOB { get; set; }

        public int Gender { get; set; }

        public int MaritalStatus { get; set; }

        public string IDOrPassportNo { get; set; }

        public string PhoneNumber { get; set; }

    }
}

using SocialAssistInfoSystem.Client.Data.Enum;

namespace SocialAssistInfoSystem.Client.Data
{
    public class ApplicationItem
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public DateTime? DOB { get; set; }

        public Gender Gender { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public Scheme Scheme { get; set; }
    }
}

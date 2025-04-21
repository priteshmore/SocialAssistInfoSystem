namespace SocialAssistInfoSystem.Data.Dto
{
    public class ProfileDto
    {
        public int Id { get; set; }

        public int ApplicationId { get; set; }

        //[JsonIgnore]
        //public ApplicationDto Application { get; set; }
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime? DOB { get; set; }

        public int Gender { get; set; }

        public int MaritalStatus { get; set; }

        public int PassportNo { get; set; }

        public string PhoneNumber { get; set; }

    }
}

namespace SocialAssistInfoSystem.Data.Dto
{
    public class SchemeDto
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }

        //[JsonIgnore]
        //public ApplicationDto Application { get; set; }

        public int SchemeType { get; set; }

        public string OtherScheme { get; set; }
    }
}

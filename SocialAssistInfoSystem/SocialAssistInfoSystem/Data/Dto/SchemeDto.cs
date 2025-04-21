namespace SocialAssistInfoSystem.Data.Dto
{
    public class SchemeDto
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }

        //[JsonIgnore]
        //public ApplicationDto Application { get; set; }

        public string SchemeName { get; set; }

        public string OtherScheme { get; set; }
    }
}

using SocialAssistInfoSystem.Client.Data.Enum;

namespace SocialAssistInfoSystem.Client.Data.Dto
{
    public class SchemeVM
    {
        public int Id { get; set; }
        //public int ApplicationId { get; set; }

        //[JsonIgnore]
        //public Application Application { get; set; }

        public SchemeOption SchemeType { get; set; }

        public string OtherScheme { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace SocialAssistInfoSystem.Client.Data.ViewModel
{
    public class SchemeDto
    {
        public int Id { get; set; }
        //public int ApplicationId { get; set; }

        //[JsonIgnore]
        //public Application Application { get; set; }

        public int SchemeType { get; set; }

        public string OtherScheme { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace SocialAssistInfoSystem.Data.DBEntity
{
    public class Scheme
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }

        [JsonIgnore]
        public Application Application { get; set; }

        public int SchemeType { get; set; }

        public  string OtherScheme { get; set; }
    }
}

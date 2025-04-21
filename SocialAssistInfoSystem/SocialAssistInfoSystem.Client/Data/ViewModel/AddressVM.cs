using System.Text.Json.Serialization;

namespace SocialAssistInfoSystem.Client.Data.ViewModel
{
    public class AddressVM
    {
        public int Id { get; set; }

        //public int ApplicationId { get; set; }

        //[JsonIgnore]
        //public Application Application { get; set; }

        public int Country { get; set; }

        public int Subcountry { get; set; }

        public int Location { get; set; }

        public int SubLocation { get; set; }

        public int Village { get; set; }
    }
}

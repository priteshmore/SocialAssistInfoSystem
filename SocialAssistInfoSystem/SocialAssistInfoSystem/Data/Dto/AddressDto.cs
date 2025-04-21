namespace SocialAssistInfoSystem.Data.Dto
{
    public class AddressDto
    {
        public int Id { get; set; }

        public int ApplicationId { get; set; }

        //[JsonIgnore]
        //public ApplicationDto Application { get; set; }

        public int Country { get; set; }

        public int Subcountry { get; set; }

        public int Location { get; set; }

        public int SubLocation { get; set; }

        public int Village { get; set; }
    }
}

namespace SocialAssistInfoSystem.Data.DBEntity
{
    public class Application
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public Profile Profile { get; set; }

        public Address Address { get; set; }

        public Scheme Scheme { get; set; }

    }
}

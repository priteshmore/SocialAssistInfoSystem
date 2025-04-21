using SocialAssistInfoSystem.Client.Data.ViewModel;

namespace SocialAssistInfoSystem.Client.Data.Dto
{
    public class ApplicationDto
    {
        public int Id { get; set; }

        public int Status { get; set; }

        public ProfileDto Profile { get; set; }

        public AddressDto Address { get; set; }

        public SchemeDto Scheme { get; set; }

    }
}

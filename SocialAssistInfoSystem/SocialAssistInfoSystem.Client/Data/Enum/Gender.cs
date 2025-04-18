using System.ComponentModel.DataAnnotations;

namespace SocialAssistInfoSystem.Client.Data.Enum
{
    public enum Gender
    {
        [Display(Name = "Male")]
        MALE =0,
        [Display(Name = "Female")]
        FEMALE =1,
        [Display(Name = "Any Other")]
        OTHER =2
    }
}

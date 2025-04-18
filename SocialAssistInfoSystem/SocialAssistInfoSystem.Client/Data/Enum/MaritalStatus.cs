using System.ComponentModel.DataAnnotations;

namespace SocialAssistInfoSystem.Client.Data.Enum
{
    public enum MaritalStatus
    {
        [Display(Name = "UnMarried")]
        UNMARRIED =0,
        [Display(Name = "Married")]
        MARRIED =1,
        [Display(Name = "Any Other")]
        OTHER =2
    }
}

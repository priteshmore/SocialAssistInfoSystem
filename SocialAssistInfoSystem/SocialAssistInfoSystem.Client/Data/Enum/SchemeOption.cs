using System.ComponentModel.DataAnnotations;

namespace SocialAssistInfoSystem.Client.Data.Enum
{
    public enum SchemeOption
    {
        [Display(Name = "Orphans and vulnerable children")]
        ORPHANS_AND_VULNERABLE_CHILDER = 0,
        [Display(Name = "Poor elderly persons")]
        POOR_ELDERLY_PROCESS =1,
        [Display(Name = "Persons with disability ")]
        PERSONS_WITH_DISABLITY =2,
        [Display(Name = "Persons in extreme poverty ")]
        PERSONS_WITH_CHRONIC_ILLNESS =3,
        [Display(Name = "Any other")]
        ANY_OTHER =4,
    }
}

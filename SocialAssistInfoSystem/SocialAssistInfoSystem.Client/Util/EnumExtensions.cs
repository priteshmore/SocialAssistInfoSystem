using System.ComponentModel.DataAnnotations;

namespace SocialAssistInfoSystem.Client.Util
{
    public static class EnumExtensions
    {
        // Extension to get the Display Name of Enum
        public static string GetDisplayName(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DisplayAttribute)Attribute.GetCustomAttribute(field, typeof(DisplayAttribute));
            return attribute != null ? attribute.Name : value.ToString();
        }
    }
}

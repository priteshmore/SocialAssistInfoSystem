using FluentValidation;
using SocialAssistInfoSystem.Client.Data.ViewModel;

namespace SocialAssistInfoSystem.Client.Data
{
    /// <summary>
    /// A standard AbstractValidator for the Collection Object
    /// </summary>
    /// <typeparam name="OrderDetailsModel"></typeparam>
    public class AddressDetailsModelFluentValidator : AbstractValidator<AddressVM>
    {
        public AddressDetailsModelFluentValidator()
        {
            RuleFor(x => x.Country)
                .NotEmpty();
            RuleFor(x => x.Subcountry)
                .NotEmpty();
            RuleFor(x => x.Location)
                .NotEmpty();

            RuleFor(x => x.Subcountry)
                .NotEmpty();

            RuleFor(x => x.Village)
               .NotEmpty();
        }

        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<AddressVM>.CreateWithOptions((AddressVM)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}

using FluentValidation;
using SocialAssistInfoSystem.Client.Data.ViewModel;

namespace SocialAssistInfoSystem.Client.Data
{
    /// <summary>
    /// A standard AbstractValidator which contains multiple rules and can be shared with the back end API
    /// </summary>
    /// <typeparam name="OrderModel"></typeparam>
    public class ApplicationFluentValidator : AbstractValidator<ApplicationVM>
    {
        public ApplicationFluentValidator()
        {
            //RuleFor(x => x.Profile.FirstName)
            //    .NotEmpty()
            //    .Length(1, 100);
            //RuleFor(x => x.Profile.MiddleName)
            //   .NotEmpty()
            //   .Length(1, 100);
            //RuleFor(x => x.Profile.LastName)
            //  .NotEmpty()
            //  .Length(1, 100);

            //RuleFor(x => x.Profile.DOB)
            //.NotEmpty();

            //RuleFor(x => x.Address).SetValidator(new AddressDetailsModelFluentValidator());

            //RuleFor(x => x.PassportNo)
            //    .NotEmpty()
            //    .Length(1, 100)
            //    .CreditCard();

            //RuleFor(x => x.Profile.PassportNo)
            //    .NotEmpty()
            //    .Length(1, 100);

            //RuleFor(x => x.Address.Address)
            //    .NotEmpty()
            //    .Length(1, 100);

            //RuleFor(x => x.Address.City)
            //    .NotEmpty()
            //    .Length(1, 100);

            //RuleFor(x => x.Address.Country)
            //    .NotEmpty()
            //    .Length(1, 100);

            //RuleFor(x => x.Address.Location)
            // .NotEmpty()
            // .Length(1, 100);

            //RuleForEach(x => x.Address)
            //    .SetValidator(new OrderDetailsModelFluentValidator());
        }

        private async Task<bool> IsUniqueAsync(string email)
        {
            // Simulates a long running http call
            await Task.Delay(2000);
            return email.ToLower() != "test@test.com";
        }

        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<ApplicationVM>.CreateWithOptions((ApplicationVM)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }

}

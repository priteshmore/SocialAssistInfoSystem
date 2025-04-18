using FluentValidation;

namespace SocialAssistInfoSystem.Client.Data
{
    /// <summary>
    /// A standard AbstractValidator for the Collection Object
    /// </summary>
    /// <typeparam name="OrderDetailsModel"></typeparam>
    public class OrderDetailsModelFluentValidator : AbstractValidator<OrderDetailsModel>
    {
        public OrderDetailsModelFluentValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                .Length(1, 100);

            RuleFor(x => x.Offer)
                .GreaterThan(0)
                .LessThan(999);
        }

        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<OrderDetailsModel>.CreateWithOptions((OrderDetailsModel)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}

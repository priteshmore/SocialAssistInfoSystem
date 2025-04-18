﻿using FluentValidation;
using static SocialAssistInfoSystem.Client.Pages.Application;

namespace SocialAssistInfoSystem.Client.Data
{
    /// <summary>
    /// A standard AbstractValidator which contains multiple rules and can be shared with the back end API
    /// </summary>
    /// <typeparam name="OrderModel"></typeparam>
    public class OrderModelFluentValidator : AbstractValidator<ApplicationModel>
    {
        public OrderModelFluentValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .Length(1, 100);

            //RuleFor(x => x.Email)
            //    .Cascade(CascadeMode.Stop)
            //    .NotEmpty()
            //    .EmailAddress()
            //    .MustAsync(async (value, cancellationToken) => await IsUniqueAsync(value));

            //RuleFor(x => x.PassportNo)
            //    .NotEmpty()
            //    .Length(1, 100)
            //    .CreditCard();

            RuleFor(x => x.PassportNo)
                .NotEmpty()
                .Length(1, 100);

            RuleFor(x => x.Address.Address)
                .NotEmpty()
                .Length(1, 100);

            RuleFor(x => x.Address.City)
                .NotEmpty()
                .Length(1, 100);

            RuleFor(x => x.Address.Country)
                .NotEmpty()
                .Length(1, 100);

            //RuleForEach(x => x.OrderDetails)
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
            var result = await ValidateAsync(ValidationContext<ApplicationModel>.CreateWithOptions((ApplicationModel)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }

}

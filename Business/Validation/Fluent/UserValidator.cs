using Core.Entities.Concrete;
using FluentValidation;


namespace Business.Validation.Fluent
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MinimumLength(2).MaximumLength(20).WithMessage("Kullanıcı adı 2 ile 20 karakter arasında olmalıdır.");
            //RuleFor(p => p.UserPassword).NotEmpty();
            //RuleFor(p => p.UserPassword).MinimumLength(5).MaximumLength(20).WithMessage("Parolanız adı 5 ile 20 karakter arasında olmalıdır.");
            //RuleFor(p => p.Description).GreaterThan(0);
            //RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
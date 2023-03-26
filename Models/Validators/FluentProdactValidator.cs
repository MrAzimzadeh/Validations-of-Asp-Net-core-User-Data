using System.Data;
using FluentValidation;

namespace ValidationsofAspNetcoreUserData.Models.Validators
{
    public class FluentProdactValidator  :AbstractValidator<FluentProdact>
    {
        public FluentProdactValidator()
        {
            //validasya 
            
            RuleFor(x=>x.Email).NotNull().WithMessage("Email Bos ola bilmez ");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Adam kimi mail yaz !");

            RuleFor(x => x.Name).NotNull().WithMessage("Bos Ola bilmez Kazyol");
            RuleFor(x => x.Name).MaximumLength(5).WithMessage("5  kece bilmezz");

        }
    }
}

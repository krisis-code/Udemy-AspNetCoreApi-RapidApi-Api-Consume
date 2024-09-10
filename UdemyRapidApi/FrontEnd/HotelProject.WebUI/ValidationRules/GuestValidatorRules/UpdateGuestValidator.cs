using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidatorRules
{
    public class UpdateGuestValidator : AbstractValidator<GuestUpdateDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name)
    .NotEmpty()
    .WithMessage("İsim alanı boş olamaz.")
    .MinimumLength(3)
    .WithMessage("İsim en az 3 karakter olmalıdır.")
    .MaximumLength(20)
    .WithMessage("İsim en fazla 20 karakter olabilir.");

            RuleFor(x => x.SureName)
                .NotEmpty()
                .WithMessage("Soyisim alanı boş olamaz.")
                .MinimumLength(2)
                .WithMessage("Soyisim en az 2 karakter olmalıdır.")
                .MaximumLength(30)
                .WithMessage("Soyisim en fazla 30 karakter olabilir.");
        }
    }
}

using Domain.Entities;
using FluentValidation;

namespace Domain.Validations
{
    public class ShoeValidator : AbstractValidator<Shoe>
    {
        public ShoeValidator()
        {
            RuleFor(x => x.ImageData)
                .Must(BeValidImageSize)
                .WithMessage("Image size must not exceed 2 MB.");
        }

        private bool BeValidImageSize(byte[] imageData)
        {
            if (imageData == null)
            {
                return true; // It's valid if no image is provided
            }

            const int maxSizeInBytes = 2097152; // 2 MB
            return imageData.Length <= maxSizeInBytes;
        }
    }
}

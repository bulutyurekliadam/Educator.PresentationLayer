﻿using Microsoft.AspNetCore.Identity;

namespace Educator.PresentationLayer.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description = "Parola çok kısa lütfen en az 6 karakter veri girişi yapın."
            };

        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresLower",
                Description = "Parola en az 1 adet küçük harf içermelidir. "
            };

        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola en az 1 adet büyük harf içermelidir. "
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Paorla en az 1 adet sembol içermelidir."
            };
        }
      
    }
}

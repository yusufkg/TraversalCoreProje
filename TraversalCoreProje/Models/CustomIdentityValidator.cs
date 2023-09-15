using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProje.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooshort",
				Description = $"Parola Minimum { length } karakter olmalıdır"
			};
		}

        public override IdentityError PasswordRequiresUpper()
        {
			return new IdentityError()
			{
				Code = "PasswordReuiresUpper",
				Description = "Parola en az 1 büyük harf içermelidir"
			};
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordReuiresLower",
                Description = "Parola en az 1 küçük harf içermelidir"
            };
        }
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola en az 1 sembol içermelidir"
            };
        }
	}
}

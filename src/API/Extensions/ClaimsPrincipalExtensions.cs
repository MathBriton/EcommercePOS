using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string RetrieveEmailFromPrincipal(this ClaimsPrincipalExtensions user)
        {
            return user.FindFirstValue(ClaimsTypes.Email);
        }
    }
}
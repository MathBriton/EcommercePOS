using Microsoft.AspNetCore.Identity;
namespace Core.Entities.Identity
{
    public class AppUser : IdentityUser
    {
        public sstring DisplayName { get; set; }
        public Address Address { get; set; }
    }
}
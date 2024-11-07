using Microsoft.AspNetCore.Identity;

namespace Tinas_Torskfiléer_Backend.Models
{
    public class User : IdentityUser
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Title { get; set; }
    }
}

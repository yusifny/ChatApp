using Microsoft.AspNetCore.Identity;

namespace MySignalR.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
        public string ConnectionId { get; set; }
    }
}
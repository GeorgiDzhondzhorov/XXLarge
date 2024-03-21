using Microsoft.AspNetCore.Identity;
using System.Data;

namespace XXLarge.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateModified { get; set; } = DateTime.Now;
        public ICollection<Order> Orders { get; set; }
    }
}

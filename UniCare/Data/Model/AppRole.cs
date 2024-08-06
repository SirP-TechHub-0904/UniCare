using Microsoft.AspNetCore.Identity;

namespace UniCare.Data.Model
{
    public class AppRole : IdentityRole
    {
        public string Description { get; set; }
    }
}

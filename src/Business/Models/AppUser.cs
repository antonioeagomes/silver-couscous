using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Extensions;
using Microsoft.AspNetCore.Identity;

namespace Business.Models
{
    public class AppUser : IdentityUser<int>
    {

        public string Name { get; set; }
        public string City { get; set; }
        public string About { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public DateTime DateOfBirth { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }

        public int GetAge() {
            return DateOfBirth.CalculateAge();
        }
    }
}
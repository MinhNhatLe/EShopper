using System;
using System.Collections.Generic;

#nullable disable

namespace AdvancedEShop.Models.Entities
{
    public partial class User
    {
        public User()
        {
            Categories = new HashSet<Category>();
            Colors = new HashSet<Color>();
            Sizes = new HashSet<Size>();
        }

        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsAdmin { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Color> Colors { get; set; }
        public virtual ICollection<Size> Sizes { get; set; }
    }
}

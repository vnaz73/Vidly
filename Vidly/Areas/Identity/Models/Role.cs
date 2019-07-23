using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.Areas.Identity.Models
{
    public class Role:IdentityRole<string>
    {
        public Role() : base()
        {

        }
        public Role(string roleName) : base(roleName)
        {

        }
    }
}

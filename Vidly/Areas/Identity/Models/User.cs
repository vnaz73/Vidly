using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.Areas.Identity.Models
{
    public class User: IdentityUser<string>
    {
        public string DrivingLicense { get; set; }
    }
}

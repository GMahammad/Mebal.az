using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class MebelanUser:IdentityUser
    {
        [Required]
        public string Firstname { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPDevelopment.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(1024, MinimumLength = 3)]
        public string Message { get; set; }
    }
}

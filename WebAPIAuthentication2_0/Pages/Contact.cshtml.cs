﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAPIAuthentication2_0.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your contact page.";
        }
    }
}

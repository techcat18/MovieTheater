﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class ForgotPasswordDTO
    {
        public string Email { get; set; }
        public string ClientURI { get; set; }
    }
}

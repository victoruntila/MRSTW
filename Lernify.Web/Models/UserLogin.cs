﻿using System;

namespace Lernify.Web.Models
{
     public class UserLogin
     {
          public string Credential { get; set; }
          public string Password { get; set; }
          public string LoginIp { get; set; }
          public DateTime LoginDateTime { get; set; }
     }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLogin.Models
{
    public class role
    {
        public int roleId { get; set; }
        public string? roleName { get; set; }
        public virtual ICollection<user>? users { get; set; }
    }
}

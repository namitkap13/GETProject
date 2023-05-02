
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLogin.DAL
{
    class UserContext : DbContext
    {
        public UserContext() : base()
        {
           
        }
    }
}

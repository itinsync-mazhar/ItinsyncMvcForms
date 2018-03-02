using Intinsync.MvcForms.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intinsync.DAL.DBContexts
{
    public class IdentityDB : IdentityDbContext<ApplicationUser>
    {
        public IdentityDB() : base("DefaultConnection", throwIfV1Schema: false)
        {

        }
        public static IdentityDB Create()
        {
            return new IdentityDB();
        }
    }
}

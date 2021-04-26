using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_SESSIONMEMBERSHIP.DATA.Model_Entity;

namespace MVC_SESSIONMEMBERSHIP.DAL.Context
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext()
            : base("Server=.; Database=ECommerceDB; Integrated Security=SSPI")
        {
        }
        public DbSet<WebRole> RoleTable { get; set; }
        public DbSet<WebUser> UserTable { get; set; }
    }
}

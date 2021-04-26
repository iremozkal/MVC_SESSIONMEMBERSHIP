using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_SESSIONMEMBERSHIP.DATA.Model_Entity
{
    public class WebRole
    {
        public int WebRoleId { get; set; }
        public string WebRoleName { get; set; }
        public List<WebUser> WebRoleUsers { get; set; }
    }
}

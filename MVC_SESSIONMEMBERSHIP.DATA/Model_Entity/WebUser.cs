using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_SESSIONMEMBERSHIP.DATA.Model_Entity
{
    public class WebUser
    {
        public int WebUserId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordAgain { get; set; }
        public int WebRolId { get; set; }
        public WebRole UserWebRole { get; set; }
    }
}

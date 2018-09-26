using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HSDL_IDM_P2.Lib.Entity.UserAdmin
{
    public class UserEntity
    {
        public String ID { get; set; }
        public String UserID { get; set; } //user name
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Telephone { get; set; }
        public String Status { get; set; }
        public String UserType { get; set; }
    }
}

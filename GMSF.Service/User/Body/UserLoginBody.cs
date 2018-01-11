using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSF.Service.User.Body
{
    public class UserLoginRequestBody
    {
        public string UserAccount { get; set; }
        public string UserPwd { get; set; }
        public string CheckCode { get; set; }
    }

    public class UserLoginResponseBody
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int UserSex { get; set; }
        public string UserRemark { get; set; }
    }
}

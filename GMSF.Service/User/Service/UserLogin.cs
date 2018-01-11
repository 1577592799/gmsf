using GMSF.Service.User.Body;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSF.Service.User.Service
{
    public class UserLogin : ServiceHandler<UserLoginRequestBody, UserLoginResponseBody>
    {
        public UserLogin(UserLoginRequestBody request) : base(request) { }

        protected override void ValidateRequestParams()
        {
            base.ValidateRequestParams();
            if (string.IsNullOrEmpty(this.request.UserAccount))
            {
                throw new ArgumentNullException("UserAccount");
            }
        }

        public override UserLoginResponseBody ExecuteCore()
        {
            return new UserLoginResponseBody()
            {
                UserId = 1,
                UserName = "张三",
                UserRemark = "Select environment, namespace, and table to generate a form",
                UserSex = 0,
            };
        }
    }
}

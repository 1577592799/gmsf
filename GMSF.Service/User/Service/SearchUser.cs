using GMSF.Service.User.Body;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSF.Service.User.Service
{
    public class SearchUser : ServiceHandler<SearchUserRequestBody, SearchUserResponseBody>
    {
        public SearchUser(SearchUserRequestBody request) : base(request)
        {
        }

        protected override void ValidateRequestParams()
        {
            base.ValidateRequestParams();
            if (string.IsNullOrEmpty(this.request.Key))
            {
                throw new ArgumentNullException("Key");
            }
        }

        public override SearchUserResponseBody ExecuteCore()
        {
            List<UserBaseInfo> infos = new List<UserBaseInfo>()
            {
                new UserBaseInfo() {
                    UserId = 1,
                    UserName = "张三",
                    UserRemark = "Select environment, namespace, and table to generate a form",
                    UserSex = 0
                },
                new UserBaseInfo() {
                    UserId = 2,
                    UserName = "李四",
                    UserRemark = "不知道说些什么好了...",
                    UserSex = 1
                },
            };

            return new SearchUserResponseBody() { UserBaseInfos = infos };
        }
    }
}

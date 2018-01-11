using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSF.Service.User.Body
{
    public class SearchUserRequestBody
    {
        public string Key { get; set; }
    }

    public class SearchUserResponseBody
    {
        public List<UserBaseInfo> UserBaseInfos { get; set; }
    }
}

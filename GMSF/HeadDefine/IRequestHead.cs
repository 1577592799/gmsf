using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSF.HeadDefine
{
    public interface IRequestHead
    {
        bool IsCheckToken { get; }
        bool IsCheckSessionId { get; }

        bool CheckToken(string token);
        bool CheckSessionId(string sessionId);
    }
}

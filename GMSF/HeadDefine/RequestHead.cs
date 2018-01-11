using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSF.HeadDefine
{
    public class RequestHead
    {
        public string Version { get; set; }
        public long Timestamp { get; set; }
        public string Token { get; set; }
        public string ClientIp { get; set; }
        public string SessionId { get; set; }
    }
}

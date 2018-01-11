
using GMSF.HeadDefine;

namespace GMSF.Model
{
    public class Response<TBody>
    {
        public ResponseHead Head{ get; set; }

        public TBody Body { get; set; }
    }
}

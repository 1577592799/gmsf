using GMSF.HeadDefine;

namespace GMSF.Model
{
    public class Request<TBody>
    {
        public RequestHead Head { get; set; }

        public TBody Body { get; set; }
    }
}

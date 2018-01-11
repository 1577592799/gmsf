using GMSF.HeadDefine;
using GMSF.Model;
using System;

namespace GMSF
{
    /// <summary>
    /// 封装服务请求上下文
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    public class ServiceContext<TRequest>
    {
        public Request<TRequest> CurrentRequest { get; private set; }
        private IRequestHead reqValidate;

        public ServiceContext(Request<TRequest> request, IRequestHead reqValidate = null)
        {
            this.CurrentRequest = request;
            this.SetRequestValidate(reqValidate);
        }

        public void SetRequestValidate(IRequestHead reqValidate)
        {
            this.reqValidate = reqValidate;
        }

        public string GetCurrentSessionId()
        {
            if (this.CurrentRequest != null && this.CurrentRequest.Head != null)
            {
                return this.CurrentRequest.Head.SessionId;
            }
            return null;
        }

        public string GetCurrentToken()
        {
            if (this.CurrentRequest != null && this.CurrentRequest.Head != null)
            {
                return this.CurrentRequest.Head.Token;
            }
            return null;
        }

        public bool CheckSessionId()
        {
            if (!this.reqValidate.IsCheckSessionId) return true;

            if (this.reqValidate == null) return false;

            bool sessionSucc = this.reqValidate.CheckSessionId(this.GetCurrentSessionId());
            return sessionSucc;
        }

        public bool CheckToken()
        {
            if (!this.reqValidate.IsCheckToken) return true;

            if (this.reqValidate == null) return false;

            bool tokenSucc = this.reqValidate.CheckToken(this.GetCurrentToken());
            return tokenSucc;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSF
{
    public abstract class ServiceHandler<TRequestBody> : IService
    {
        protected TRequestBody request;

        public ServiceHandler(TRequestBody request)
        {
            this.request = request;
        }

        protected virtual void ValidateRequestParams()
        {
            if (this.request == null)
            {
                throw new ArgumentNullException("request");
            }
        }

        public abstract void ExecuteCore();

        public void Execute()
        {
            this.ValidateRequestParams();
            this.ExecuteCore();
        }
    }


    public abstract class ServiceHandler<TRequestBody, TResponseBody> : IService<TResponseBody>
    {
        protected TRequestBody request;

        public ServiceHandler(TRequestBody request)
        {
            this.request = request;
        }

        protected virtual void ValidateRequestParams()
        {
            if (this.request == null)
            {
                throw new ArgumentNullException("request");
            }
        }

        public abstract TResponseBody ExecuteCore();

        public TResponseBody Execute()
        {
            this.ValidateRequestParams();

            return this.ExecuteCore();
        }
    }
}

using GMSF.HeadDefine;
using GMSF.Model;
using System;

namespace GMSF
{
    /// <summary>
    /// 根据服务上下文调用对应业务逻辑处理过程，并返回处理结果
    /// </summary>
    public class ContextProcessor
    {
        public static Response<TResponse> Execute<TRequest, TResponse>(ServiceContext<TRequest> context, Func<Request<TRequest>, TResponse> func)
        {
            Response<TResponse> response = new Response<TResponse>()
            {
                Head = new ResponseHead()
                {
                    ResultCode = null,
                    ResultMessage = null,
                },
            };

            //验证头参数
            bool sessionSucc = context.CheckSessionId();
            if (!sessionSucc)
            {
                response.Head.ResultCode = ResponseResult.RELOGIN;
                response.Head.ResultMessage = "会话过期";
                return response;
            }
            bool tokenSucc = context.CheckToken();
            if (!tokenSucc)
            {
                response.Head.ResultCode = ResponseResult.RELOGIN;
                response.Head.ResultMessage = "登录TOKEN过期";
                return response;
            }

            try
            {
                //执行流程处理
                if (func != null)
                {
                    TResponse res = func(context.CurrentRequest);
                    response.Body = res;
                    response.Head.ResultCode = ResponseResult.SUCCESS;
                    response.Head.ResultMessage = null;
                    return response;
                }
                else
                {
                    throw new Exception("上正文处理过程错误");
                }
            }
            catch (Exception ex)
            {
                response.Head.ResultCode = ResponseResult.FAILED;
                response.Head.ResultMessage = ex.Message;
            }
            return response;
        }
    }
}

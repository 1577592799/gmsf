
namespace GMSF
{
    public interface IService
    {
        void Execute();
    }

    public interface IService<TResponse>
    {
        TResponse Execute();
    }
}

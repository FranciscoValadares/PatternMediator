using System;
using System.Threading.Tasks;

namespace BibliotecasMediator.Mediator
{
    public interface IHandle<TRequest, TResponse> where TRequest: IRequest<TResponse>
    {
        Task<TResponse> HandleSeViraNosTrinta(TRequest request);
    }
}

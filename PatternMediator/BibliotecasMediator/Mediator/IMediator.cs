using System;
using System.Threading.Tasks;

namespace BibliotecasMediator.Mediator
{
    public interface IMediator
    {
        Task<TResponse> SendInformacao<TResponse>(IRequest<TResponse> request);
        
    }
}

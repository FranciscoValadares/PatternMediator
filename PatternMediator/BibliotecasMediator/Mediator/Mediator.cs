
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BibliotecasMediator.Mediator
{
    public class Mediator: IMediator
    {

        private readonly Func<Type, object> _serviceResolver;
        private readonly IDictionary<Type, Type> _handlerDetails;


        public Mediator(Func<Type, object> serviceResolver, IDictionary<Type, Type> handlerDetails)
        {
            _serviceResolver = serviceResolver;
            _handlerDetails = handlerDetails;

        }


        public async Task<TResponse> SendInformacao<TResponse>(IRequest<TResponse> requisicao)
        
        {

            var requestType = requisicao.GetType();
            if (!_handlerDetails.ContainsKey(requestType))
            {
                throw new Exception($"Nenhum handler/manipulador para a requisição to tipo: {requestType.Name}");
            }

            _handlerDetails.TryGetValue(requestType, out var requestHandlerType);
            var handler = _serviceResolver(requestHandlerType);

            var obj = handler.GetType().GetMethod("HandleSeViraNosTrinta").Invoke(handler, new[] { requisicao });

            return await(Task<TResponse>)obj;


        }
    }
}

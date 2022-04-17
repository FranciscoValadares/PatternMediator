using System;
using System.Threading.Tasks;
using BibliotecasMediator.ClassesCorporativas;
using BibliotecasMediator.Mediator;

namespace BibliotecasConsumerMediator.RegrasDeNegocio
{
    public class ChamarPrestacaoContasHandler : IHandle<ChamarPrestacaoContasRequest, string>
    {
        //private readonly IMediator _mediator;

        //public ChamarPrestacaoContasHandler(IMediator mediator)
        //{
        //    _mediator = mediator;
        //}
         
        public Task<string> HandleSeViraNosTrinta(ChamarPrestacaoContasRequest request)
        {
            var prestacaoContas = new PrestacaoContas();
                
            //TODO Realiza todas as acoes necessárias p/ CHAMAR_PRESTACAO_CONTAS de contas e devolve uma string
            Console.WriteLine(request.cpf);
            return Task.FromResult(request.cpf);
        }
    }
}

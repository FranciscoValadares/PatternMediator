using System;
using System.Threading.Tasks;
using BibliotecasMediator.ClassesCorporativas;
using BibliotecasMediator.Mediator;

namespace BibliotecasConsumerMediator.RegrasDeNegocio
{
    public class AtribuirCursoAPrestacaoContaHandler: IHandle<AtribuirCursoAPrestacaoContaRequest, PrestacaoContas>
    {
        public AtribuirCursoAPrestacaoContaHandler()
        {
        }

        public Task<PrestacaoContas> HandleSeViraNosTrinta(AtribuirCursoAPrestacaoContaRequest request)
        {
            return Task.FromResult(
                AtribuirCursoNaPrestacaoConta(
                    request._prestacaoContas.id,
                    request._profissional.Id,
                    request._curso.id
                )
            ); 
        }

        private PrestacaoContas AtribuirCursoNaPrestacaoConta(int idPrestacao,int idProfissional, int idCurso)
        {
            //TODO implementa toda logica necessária
            return null;
        }

    }
}

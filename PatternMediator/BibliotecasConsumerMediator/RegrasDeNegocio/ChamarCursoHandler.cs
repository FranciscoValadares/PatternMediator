using System;
using System.Threading.Tasks;
using BibliotecasMediator.ClassesCorporativas;
using BibliotecasMediator.Mediator;

namespace BibliotecasConsumerMediator.RegrasDeNegocio
{
    public class ChamarCursoHandler : IHandle<ChamarCursoRequest, Curso>
    {
        public Task<Curso> HandleSeViraNosTrinta(ChamarCursoRequest request)
        {
            Console.WriteLine(request.codigoCurso);
            //TODO Realiza todas as acoes necessárias p/ CHAMAR_PRESTACAO_CONTAS de contas e devolve uma string
            var curso = new Curso();
            
            return Task.FromResult(curso);
        }
    }
}


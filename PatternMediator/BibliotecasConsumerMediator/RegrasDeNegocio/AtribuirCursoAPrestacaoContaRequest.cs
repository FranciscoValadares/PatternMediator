using System;
using BibliotecasMediator.ClassesCorporativas;
using BibliotecasMediator.Mediator;

namespace BibliotecasConsumerMediator.RegrasDeNegocio
{
    public class AtribuirCursoAPrestacaoContaRequest: IRequest<PrestacaoContas>
    {
        public PrestacaoContas _prestacaoContas {  get; private set; }
        public Profissional _profissional { get; private set; }
        public Curso _curso { get; private set; }

        public AtribuirCursoAPrestacaoContaRequest(
            PrestacaoContas prestacaoContas,
            Profissional profissional,
            Curso curso
        )
        {
            _prestacaoContas = prestacaoContas;
            _profissional = profissional;
            _curso = curso;
        }


    }
}

using System;
using BibliotecasMediator.ClassesCorporativas;
using BibliotecasMediator.Mediator;

namespace BibliotecasConsumerMediator.RegrasDeNegocio
{
    public class ChamarCursoRequest : IRequest<Curso>
    {
        public string codigoCurso { get; set; }
    }

    
}

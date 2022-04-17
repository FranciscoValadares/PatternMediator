using System;
using BibliotecasMediator.ClassesCorporativas;
using BibliotecasMediator.Mediator;

namespace BibliotecasConsumerMediator.RegrasDeNegocio
{
    public class ChamarPrestacaoContasRequest: IRequest<string>
    {
        public int id { get; set; }
        public string nomeProfissional { get; set; }
        public string cpf { get; set; }
    }
}

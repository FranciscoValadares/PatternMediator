using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BibliotecasConsumerMediator.RegrasDeNegocio;
using BibliotecasMediator.Mediator;
using Microsoft.Extensions.DependencyInjection;

namespace BibliotecasConsumerMediator
{
    class Program
    {
         
        static async Task<int> Main(string[] args)
        {

            var serviceProvider = new ServiceCollection()
                .AddTransient<ChamarPrestacaoContasHandler>()
                .BuildServiceProvider();

            var handlerDetails = new Dictionary<Type, Type>
            {
                { typeof(ChamarPrestacaoContasRequest), typeof(ChamarPrestacaoContasHandler)}
            };


            IMediator mediator = new Mediator(serviceProvider.GetRequiredService, handlerDetails);


            var cadastrar = new ChamarPrestacaoContasRequest
            {
                cpf = "00581000052"
            };
            Console.WriteLine("Hello World!");
            await mediator.SendInformacao(cadastrar);

            return 0; 

             
        }
    }
}


//# Referencias
// https://www.youtube.com/watch?v=4e83trumwcM
// https://medium.com/qualyteam-engineering/design-pattern-mediator-6b4722b5a1ce
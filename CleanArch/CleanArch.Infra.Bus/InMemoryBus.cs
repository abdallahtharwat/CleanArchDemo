using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CleanArch.Domain.Core.Commands.Command;

namespace CleanArch.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }  

        public Task SendCommand<T>(T commend) where T : Command
        {
            return _mediator.Send(commend);
        }


        //public Task<int> SendQRCodeCommand<T>(T command) where T : CommandproductService
        //{
        //    return _mediator.Send(command);
        //}




    }
}

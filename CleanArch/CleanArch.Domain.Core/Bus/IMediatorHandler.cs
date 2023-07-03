using CleanArch.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CleanArch.Domain.Core.Commands.Command;

namespace CleanArch.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;

        //Task<int> SendQRCodeCommand<T>(T command) where T : CommandproductService;





    }
}

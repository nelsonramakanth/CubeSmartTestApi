using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interface
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand  
    { 
        public string Handler(TCommand command);
    }
}

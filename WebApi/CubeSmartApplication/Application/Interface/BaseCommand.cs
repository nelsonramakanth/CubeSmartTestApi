using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interface
{
    public interface ICommand
    {
        Guid CommandId { get; set; }
    }
    public class BaseCommand : ICommand
    {
        public Guid CommandId { get; set; }

        public BaseCommand()
        {
            CommandId = Guid.NewGuid();
        }
    }
}

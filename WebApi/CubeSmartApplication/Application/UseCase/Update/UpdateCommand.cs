using Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase.Update
{
    public class UpdateCommand : BaseCommand
    {
        public string Data { get; set; }
    }
}

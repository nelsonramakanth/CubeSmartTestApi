using Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase.Create
{
    public class CreateCommand : BaseCommand
    {
        public string Data { get; set; }
    }
}

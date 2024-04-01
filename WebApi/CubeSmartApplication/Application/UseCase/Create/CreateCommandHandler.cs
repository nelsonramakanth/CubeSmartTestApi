
using Application.Interface;
using Application.Reposatory;

namespace Application.UseCase.Create
{
    public class CreateCommandHandler : ICommandHandler<CreateCommand>
    {
        public string Handler(CreateCommand command)
        {
           return CubeSmartRepo.Insert(command.Data);
        }
    }
}

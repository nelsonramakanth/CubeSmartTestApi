
using Application.Interface;
using Application.Reposatory;

namespace Application.UseCase.Update
{
    public class UpdateCommandHandler : ICommandHandler<UpdateCommand>
    {
        public string Handler(UpdateCommand command)
        {
            return CubeSmartRepo.Update(command.Data);
        }
    }
}

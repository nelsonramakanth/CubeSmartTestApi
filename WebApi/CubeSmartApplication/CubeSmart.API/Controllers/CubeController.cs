using Application.Interface;
using Application.UseCase.Create;
using Application.UseCase.Update;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CubeSmart.API.Controllers
{
    [ApiController]
    [Route("api/cube")]
    public class CubeController : ControllerBase
    {
        private readonly ILogger<CubeController> _logger;
        private readonly ICommandHandler<CreateCommand> _createHand;
        private readonly ICommandHandler<UpdateCommand> _updateHand;

        public CubeController(ILogger<CubeController> logger,
            ICommandHandler<CreateCommand> createHand,
            ICommandHandler<UpdateCommand> updateHand)
        {
            _logger = logger;
            _createHand = createHand;
            _updateHand = updateHand;
        }

        [HttpPost]
        [Route("insert")]
        public string Insert(string data)
        {
            if(data == null) throw new ArgumentNullException("data");
            return _createHand.Handler(new CreateCommand() { Data = data});
        }


        [HttpPost]
        [Route("update")]
        public string Update(string data)
        {
            if (data == null) throw new ArgumentNullException("data");
            return _updateHand.Handler(new UpdateCommand() { Data = data });
        }

        [HttpGet]
        [Route("get")]
        public async Task<string> Get()
        {
            return "test";
        }
    }
}

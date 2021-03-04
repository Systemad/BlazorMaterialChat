using BlazorMaterialChat.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMaterialChat.Server.Models;

namespace BlazorMaterialChat.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UsersController> logger;
        private readonly BlazorMaterialChatContext _context;

        public UsersController(ILogger<UsersController> logger, BlazorMaterialChatContext context)
        {
            this.logger = logger;
            this._context = context;
        }

        [HttpGet]
        public List<User> Get()
        {
            return _context.Users.ToList();
        }
    }
}

using BlazorMaterialChat.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BlazorMaterialChat.Server.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace BlazorMaterialChat.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UserController> logger;
        private readonly BlazorMaterialChatContext _context;

        public UserController(ILogger<UserController> logger, BlazorMaterialChatContext context)
        {
            this.logger = logger;
            this._context = context;
        }

        [HttpGet]
        public List<User> Get()
        {
            return _context.Users.ToList();
        }


        [HttpPost("loginuser")]
        public async Task<ActionResult<User>> LoginUser(User user)
        {
            User loggedInUser = await _context.Users.Where(u =>
                u.Username == user.Username && u.Password == user.Password)
                .FirstOrDefaultAsync();

            if (loggedInUser != null)
            {
                // create claim
                var claim = new Claim(ClaimTypes.Name, loggedInUser.Username);
                
                // create claimsIdentity
                var claimsIdentity = new ClaimsIdentity(new[] {claim}, "serverAuth");
                
                // create claimsPrincipal
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                // sign in user
                await HttpContext.SignInAsync(claimsPrincipal);
            }
            return await Task.FromResult(loggedInUser);
        }
        
        [HttpGet("getcurrentuser")]
        public async Task<ActionResult<User>> GetCurrentUser()
        {
            User currentUser = new User();
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                currentUser.Username = User.FindFirstValue(ClaimTypes.Name);
            }
            
            return await Task.FromResult(currentUser);
        }
        
        [HttpGet("getprofile/{userId}")]
        public async Task<User> GetProfile(int userId)
        {
            return await _context.Users.Where(u => u.UserId == userId).FirstOrDefaultAsync();
        }

        [HttpGet("logoutuser")]
        public async Task<ActionResult<String>> Logoutuser()
        {
            await HttpContext.SignOutAsync();
            return "Success";
        }
        
        
        
    }
}

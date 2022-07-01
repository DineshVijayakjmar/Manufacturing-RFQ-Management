using AuthMicroservice.Models;
using AuthMicroservice.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Cors;

namespace AuthMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AuthController : ControllerBase
    {
        private IConfiguration _config;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AuthController));
        private readonly IAuthRepo repo;


        public AuthController(IConfiguration config, IAuthRepo _repo)
        {
            _config = config;
            repo = _repo;
        }

        /// <summary>
        /// Post method for Login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Login([FromBody] Auth login)
        {
            RFQRepo auth_repo = new RFQRepo(_config, repo);
            _log4net.Info("Login initiated!");
            IActionResult response = Unauthorized();
            //login.FullName = "user1";
            var user = auth_repo.AuthenticateUser(login);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                var tokenString = auth_repo.GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }





    }
}

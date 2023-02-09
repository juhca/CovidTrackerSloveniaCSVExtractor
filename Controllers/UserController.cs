using IndigoLabs2.Contract;
using IndigoLabs2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IndigoLabs2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IUserService _userService;

        public UserController(IRepositoryManager repository, IUserService userService)
        {
            _repository = repository;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            //var users = _repository.User.GetAllUsers();
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        //[HttpPost]
        //public IActionResult CreateUsers(string username, string password)
        //{
        //    var user = new Models.User
        //    {
        //        Username = "uporabnik01",
        //        Password = "000000"
        //    };

        //    _repository.User.CreateUser(user);
        //    _repository.Save();
        //    return Ok();
        //}

        //[HttpDelete]
        //[Route ("DeleteAllUsers")]
        //public IActionResult DeleteAllUsers()
        //{
        //    _repository.User.DeleteAllUsers();
        //    return Ok();
        //}

        //[HttpDelete]
        //public IActionResult DeleteUser(int userId)
        //{
        //    UserService.
        //    return Ok();
        //}

    }
}

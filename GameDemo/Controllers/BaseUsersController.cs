using Bussiness.Abstract;
using Bussiness.Dtos.Request;
using Bussiness.Dtos.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseUsersController : ControllerBase
    {

        private readonly IUserService _userService;

        public BaseUsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost]

        public IActionResult Add(CreateUserRequest createUserRequest)
        {
            CreateUserResponse createUserResponse= _userService.Add(createUserRequest); 

            return Ok(createUserResponse);  

        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_userService.GetAll());

        }
    }
}

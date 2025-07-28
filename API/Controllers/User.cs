using Microsoft.AspNetCore.Mvc;
using API.Services;
using API.Models;

namespace API.Controllers;

[ApiController]
[Route("api/GetUsers")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        return await _userService.GetAllUsersAsync();
    }
}
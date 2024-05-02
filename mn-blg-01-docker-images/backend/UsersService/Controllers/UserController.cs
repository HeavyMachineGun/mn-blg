using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersService.Data;
using UsersService.Models;

namespace UsersService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{

    private readonly ILogger<UserController> _logger;

    private readonly AppDbContext _context;
    
    public UserController(ILogger<UserController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> Get()
    {
        _logger.LogInformation("Getting all users");
        var users = await _context.Users.ToListAsync();
        return Ok(users);
    }

}

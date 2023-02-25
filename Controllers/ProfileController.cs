using Microsoft.AspNetCore.Mvc;
using App.Model.DTO;
using App.Model;
using AutoMapper;

[ApiController]
[Route("api/[Controller]")]
public class ProfileController : ControllerBase
{
  private readonly IMapper? mapper;
  
  public ProfileController(IMapper mapper)
  {
    this.mapper = mapper;

  
  }
  [HttpPost]
  public IActionResult Register(UserDTO? User)
  {
    UserModel UserModel = mapper!.Map<UserDTO, UserModel>(User!);
    return StatusCode(StatusCodes.Status200OK, new {
      UserModel
    });
  }
}
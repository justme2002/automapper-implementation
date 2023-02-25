using AutoMapper;
using App.Model;
using App.Model.DTO;

namespace App.Model.Mapper;

public class ProfileMapper : Profile
{
  public ProfileMapper()
  {
    CreateMap<UserDTO, UserModel>()
    .ForMember(destination => destination.UserName,
    options => {
      options.NullSubstitute("HELLO ID");
    }

    );
    CreateMap<UserModel, UserDTO>();
  }
}
using AutoMapper;

namespace Parks.Cores.Dtos
{
  public class ParkyProfile : Profile
  {
    public ParkyProfile()
    {
      CreateMap<Parky, ParkyDto>();
    }
  }
}
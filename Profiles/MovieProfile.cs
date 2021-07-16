using AutoMapper;
using csharp_apiRest.Models;
using csharp_apiRest.Data.DTOS;

namespace csharp_apiRest.Profiles
{
  public class MovieProfile : Profile
  {
    public MovieProfile()
    {
      CreateMap<CreateMovieDTO, Movie>();
      CreateMap<Movie, ReadMovieDTO>();
      CreateMap<UpdateMovieDTO, Movie>();
    }
  }
}
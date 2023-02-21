using AutoMapper;
using LocadoraApi.Data.Dtos.Jogo;
using LocadoraApi.Models;


namespace LocadoraApi.Profiles
{
    public class JogoProfile : Profile
    {
        public JogoProfile() 
        {
            CreateMap<CriaJogoDto, Jogo>()
                .ForMember(dto => dto.QuantidadeAtualEmEstoque, opts => opts
                .MapFrom(dto => dto.QuantidadeTotalDeEstoque));
            CreateMap<Jogo, LeJogoDto>();
        }
    }
}

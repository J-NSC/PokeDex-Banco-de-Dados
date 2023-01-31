using AutoMapper;
using CL.Core.Shared.ModelViews;
using Pokedex.Domain.pokemon;

namespace Pokedex.Interface.Mappings;

public class NewPokemonMappingProfile : Profile
{
	public NewPokemonMappingProfile()
	{
		CreateMap<NewPokemon, Pokemon>();
		CreateMap<NewUsuario, Usuario>();
		CreateMap<NewRegion, Regiao>();
		CreateMap<NewCategoria, Categoria>();
		CreateMap<Tipo, ReferenciaTipo>().ReverseMap();
        CreateMap<Tipo, NewTipo>().ReverseMap();
    }
}

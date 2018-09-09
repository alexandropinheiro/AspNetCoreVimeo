using AutoMapper;
using Eventos.IO.Application.ViewModels;
using Eventos.IO.Domain.Eventos;

namespace Eventos.IO.Application.AutoMapper
{
    public partial class AutoMapperConfiguration
    {
        public class ViewModelToDomainMappingProfile : Profile
        {
            public ViewModelToDomainMappingProfile()
            {
                CreateMap<Evento, EventoViewModel>();
                CreateMap<Endereco, EnderecoViewModel>();
                CreateMap<Categoria, CategoriaViewModel>();
            }
        }
    }
}

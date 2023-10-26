using AutoMapper;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Services.DTOs.Client;
using Microsoft.OpenApi.Extensions;

namespace InventoryX_Transactional.API.MapperProfiles;

public class DTOMapperProfile : Profile
{
    public DTOMapperProfile()
    {
        CreateMap<Client, ClientDTO>()
            .ForMember(dest => dest.DocumentTypeName, opt => opt.MapFrom(src => src.DocumentType.GetDisplayName()));
        CreateMap<NewClientDTO, Client>()
            .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => Guid.NewGuid()));
        CreateMap<UpdateClientDTO, Client>()
            .ForMember(dest => dest.ModifiedAt, opt => opt.MapFrom(src => DateTime.Now));
        
    }
}

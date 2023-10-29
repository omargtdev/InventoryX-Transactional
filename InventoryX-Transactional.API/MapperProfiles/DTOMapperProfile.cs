using AutoMapper;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Services.DTOs.Category;
using InventoryX_Transactional.Services.DTOs.Client;
using InventoryX_Transactional.Services.DTOs.Provider;
using InventoryX_Transactional.Services.DTOs.Warehouse;
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

        CreateMap<Provider, ProviderDTO>();
        CreateMap<NewProviderDTO, Provider>()
            .ForMember(dest => dest.ProviderId, opt => opt.MapFrom(src => Guid.NewGuid()));
        CreateMap<UpdateProviderDTO, Provider>()
            .ForMember(dest => dest.ModifiedAt, opt => opt.MapFrom(src => DateTime.Now));

        CreateMap<Category, CategoryDTO>();
        CreateMap<NewCategoryDTO, Category>();
        CreateMap<UpdateCategoryDTO, Category>()
            .ForMember(dest => dest.ModifiedAt, opt => opt.MapFrom(src => DateTime.Now));
        
        CreateMap<Warehouse, WarehouseDTO>();
        CreateMap<NewWarehouseDTO, Warehouse>();
        CreateMap<UpdateWarehouseDTO, Warehouse>()
            .ForMember(dest => dest.ModifiedAt, opt => opt.MapFrom(src => DateTime.Now));

    }
}

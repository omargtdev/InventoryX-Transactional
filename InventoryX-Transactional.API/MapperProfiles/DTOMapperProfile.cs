using AutoMapper;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Services;
using InventoryX_Transactional.Services.DTOs.Category;
using InventoryX_Transactional.Services.DTOs.Client;
using InventoryX_Transactional.Services.DTOs.Product;
using InventoryX_Transactional.Services.DTOs.Provider;
using InventoryX_Transactional.Services.DTOs.Receipt;
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

        CreateMap<NewProductDTO, Product>();

        CreateMap<ReceiptProviderDTO, NewProviderDTO>();
        CreateMap<ReceiptProductDTO, NewProductDTO>();

        CreateMap<Product, ProductDTO>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ProductId))
            .ForPath(dest => dest.Category.Id, opt => opt.MapFrom(src => src.Category.CategoryId))
            .ForPath(dest => dest.Category.Name, opt => opt.MapFrom(src => src.Category.Name))
            .ForPath(dest => dest.Warehouse.Id, opt => opt.MapFrom(src => src.Warehouse.WarehouseId))
            .ForPath(dest => dest.Warehouse.Name, opt => opt.MapFrom(src => src.Warehouse.Name))
            .ForPath(dest => dest.Price.LastReceiptPrice, opt => opt.MapFrom(src => src.ProductPrice.LastReceiptPrice))
            .ForPath(dest => dest.Price.LastIssuePrice, opt => opt.MapFrom(src => src.ProductPrice.LastIssuePrice));
    }
}

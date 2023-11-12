using AutoMapper;
using InventoryX_Transactional.API.ViewModels;
using InventoryX_Transactional.API.ViewModels.Client;
using InventoryX_Transactional.API.ViewModels.Provider;
using InventoryX_Transactional.API.ViewModels.Receipt;
using InventoryX_Transactional.API.ViewModels.Warehouse;
using InventoryX_Transactional.Services;
using InventoryX_Transactional.Services.DTOs.Category;
using InventoryX_Transactional.Services.DTOs.Client;
using InventoryX_Transactional.Services.DTOs.Provider;
using InventoryX_Transactional.Services.DTOs.Receipt;
using InventoryX_Transactional.Services.DTOs.Warehouse;
using InventoryX_Transactional.Services.Exceptions;

namespace InventoryX_Transactional.API.MapperProfiles;

public class ViewModelMapperProfile : Profile
{
    public ViewModelMapperProfile()
    {
        CreateMap<ClientDTO, ClientViewModel>();
        CreateMap<NewClientViewModel, NewClientDTO>();
        CreateMap<UpdateClientViewModel, UpdateClientDTO>();

        CreateMap<ProviderDTO, ProviderViewModel>();
        CreateMap<NewProviderViewModel, NewProviderDTO>();
        CreateMap<UpdateProviderViewModel, UpdateProviderDTO>();

        CreateMap<CategoryDTO, CategoryViewModel>();
        CreateMap<NewCategoryViewModel, NewCategoryDTO>();
        CreateMap<UpdateCategoryViewModel, UpdateCategoryDTO>();

        CreateMap<WarehouseDTO, WarehouseViewModel>();
        CreateMap<NewWarehouseViewModel, NewWarehouseDTO>();
        CreateMap<UpdateWarehouseViewModel, UpdateWarehouseDTO>();

        CreateMap<NewReceiptViewModel, NewReceiptDTO>();
        CreateMap<ReceiptProviderViewModel, ReceiptProviderDTO>();
        CreateMap<ReceiptProductViewModel, ReceiptProductDTO>();

        CreateMap<BaseException, ResponseErrorViewModel>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.ExceptionName));
    }
}

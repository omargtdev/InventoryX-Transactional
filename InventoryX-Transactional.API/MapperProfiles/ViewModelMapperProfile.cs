﻿using AutoMapper;
using InventoryX_Transactional.API.ViewModels;
using InventoryX_Transactional.Services.DTOs.Client;
using InventoryX_Transactional.Services.Exceptions;

namespace InventoryX_Transactional.API.MapperProfiles;

public class ViewModelMapperProfile : Profile
{
    public ViewModelMapperProfile()
    {
        CreateMap<ClientDTO, ClientViewModel>();
        CreateMap<NewClientViewModel, NewClientDTO>();

        CreateMap<BaseException, ResponseErrorViewModel>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.ExceptionName));
    }
}

using AutoMapper;
using Glowria.Application.Commands.Register;
using Identity.Domain.Entities;

namespace Glowria.Application.Mapping;

public class AuthProfile : Profile
{
    public AuthProfile()
    {
        CreateMap<RegisterRequest, Customer>();
    }
}
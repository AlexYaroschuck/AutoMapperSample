using AutoMapper;
using AutoMapperTests.AutoMapperResolvers;
using AutoMapperTests.Models;

namespace AutoMapperTests
{
    public static class AutoMapperConfig
    {
        public static void RegisterMapps()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Merchand, Customer>()
                    .ForMember(dest => dest.MechandLName,
                        opt => opt.MapFrom(src => src.LastName))
                    .ForMember(dest => dest.MerchandFName,
                        opt => opt.MapFrom(src => src.FirstName))
                    .ForMember(dest => dest.Item,
                        opt => opt.MapFrom(src => src.ItemName))
                    .ForMember(dest => dest.FirstName,
                        opt => opt.Ignore())
                    .ForMember(dest => dest.LastName,
                        opt => opt.Ignore());

                config.CreateMap<BillingInfo, Customer>()
                    .ForMember(dest => dest.Address,
                        opt => opt.ResolveUsing<AddressResolver>())
                    .ForMember(dest => dest.CCLastFour,
                        opt => opt.MapFrom(src => src.LastFour))
                    .ForMember(dest => dest.CCNumber,
                        opt => opt.MapFrom(src => src.CreditCardNumber));

                config.CreateMap<UserForm, Customer>()
                    .ForMember(dest => dest.FirstName,
                        opt => opt.MapFrom(src => src.Name.Split(' ')[0]))
                    .ForMember(dest => dest.LastName,
                        opt => opt.MapFrom(src => src.Name.Split(' ')[1]))
                    .ForMember(dest => dest.Email,
                        opt => opt.MapFrom(src => src.Email))
                    .ForMember(dest => dest.Age,
                        opt => opt.MapFrom(src => src.Age));

                config.CreateMap<UserForm, Customer>().ReverseMap()
                    .ForMember(dest => dest.Name,
                        opt => opt.ResolveUsing<UserFormNameResolver>());

            });
        }
    }
}

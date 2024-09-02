using AutoMapper;
using HotelProject.DtoLayer.Dtos.AboutDto;
using HotelProject.DtoLayer.Dtos.BookingDto;
using HotelProject.DtoLayer.Dtos.ContactDto;
using HotelProject.DtoLayer.Dtos.GuestDto;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room,RoomAddDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();


            CreateMap<About, AboutAddDto>();
            CreateMap<About, AboutUpdateDto>();
            CreateMap<AboutAddDto , About>().ReverseMap();
            CreateMap<AboutUpdateDto, About>().ReverseMap();

            CreateMap<BookingAddDto,Booking>().ReverseMap();
            CreateMap<BookingUpdateDto, Booking>().ReverseMap();

            CreateMap<ContactAddDto, Contact>().ReverseMap();
            CreateMap<ContactResultDto, Contact>().ReverseMap();
            CreateMap<ContactUpdateDto, Contact>().ReverseMap();

            CreateMap<GuestAddDto, Guest>().ReverseMap();
            CreateMap<GuestResultDto, Guest>().ReverseMap();
            CreateMap<GuestUpdateDto, Guest>().ReverseMap();

        }
    }
}

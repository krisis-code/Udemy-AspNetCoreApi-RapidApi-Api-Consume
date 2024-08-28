using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : GenericManager<Booking>,IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal) : base(bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public async Task TBookingStatusChangeAprovedAsync(Booking booking)
        {
            await _bookingDal.BookingStatusChangeAprovedAsync(booking);
        }

        public async Task TBookingStatusChangeAprovedByIdAsync(int id)
        {
          await  _bookingDal.BookingStatusChangeAprovedByIdAsync(id);
        }
    }
}

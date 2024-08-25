using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public async Task TDeleteAsync(Booking t)
        {
            await _bookingDal.DeleteAsync(t);
        }

        public async Task<Booking> TGetByIdAsync(int id)
        {
           return await _bookingDal.GetByIdAsync(id);
        }

        public Task<List<Booking>> TGetListAsync()
        {
            return _bookingDal.GetListAsync();
        }

        public async Task TInsertAsync(Booking t)
        {
           await _bookingDal.InsertAsync(t);
        }

        public async Task TUpdateAsync(Booking t)
        {
           await _bookingDal.UpdateAsync(t);
        }
    }
}

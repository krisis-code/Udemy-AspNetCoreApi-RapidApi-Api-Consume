using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {

        }

      
        public async Task BookingStatusChangeAprovedAsync(Booking booking)
        {
            using (var context = new Context())
            {
                var existingBooking = await context.Bookings.FindAsync(booking.BookingId);
                    

                if (existingBooking != null)
                {
                    // Rezervasyon bulunduysa, durumunu "Onaylandı" olarak değiştir
                    existingBooking.Status = "Onaylandı";

                    // Değişiklikleri veritabanına kaydet
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task BookingStatusChangeAprovedByIdAsync(int id)
        {
            using (var context = new Context())
            {
                var existingBooking = await context.Bookings.FindAsync(id);

                if (existingBooking != null)
                {
                    // Rezervasyon bulunduysa, durumunu "Onaylandı" olarak değiştir
                    existingBooking.Status = "Onaylandı";

                    // Değişiklikleri veritabanına kaydet
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}

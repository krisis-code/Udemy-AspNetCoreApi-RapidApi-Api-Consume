using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.BookingDto
{
    public class AprovedReservationDto
    {
        public int BookingId { get; set; }

        public string Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.AboutDto
{
    public class AboutUpdateDto
    {
        public int AbouId { get; set; }

        [Required(ErrorMessage = "Lütfen 1. başlığı giriniz")]
        public string Title1 { get; set; }

        [Required(ErrorMessage = "Lütfen 2. başlığı giriniz")]
        public string Title2 { get; set; }

        [Required(ErrorMessage = "Lütfen içeriği giriniz")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Lütfen oda sayısını giriniz")]
        public int RoomCount { get; set; }

        [Required(ErrorMessage = "Lütfen çalışan sayısını giriniz")]
        public int StaffCount { get; set; }

        [Required(ErrorMessage = "Lütfen Müşteri sayısını giriniz")]
        public int CustomerCount { get; set; }
    }
}

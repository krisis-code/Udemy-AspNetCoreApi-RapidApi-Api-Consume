using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {

        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet Başlığı giriniz")]
        [StringLength(100,ErrorMessage ="Hizmet başlığı maks 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Hizmet açıklma metni giriniz")]
        public string Description { get; set; }
    }
}

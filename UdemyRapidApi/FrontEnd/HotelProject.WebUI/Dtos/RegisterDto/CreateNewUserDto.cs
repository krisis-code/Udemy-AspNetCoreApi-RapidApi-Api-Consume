using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "İsim Alanı gereklidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Alanı gereklidir")]
        public string SureName { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı Alanı gereklidir")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mail Alanı gereklidir")]
        public string Mail { get; set; }
      
     

        [Required(ErrorMessage = "Şifre Alanı gereklidir")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar Alanı gereklidir")]
        [Compare("Password",ErrorMessage = "Girilen şifreler eşleşmiyor")]
        public string ConfirmPassword { get; set; }

  
    }
}

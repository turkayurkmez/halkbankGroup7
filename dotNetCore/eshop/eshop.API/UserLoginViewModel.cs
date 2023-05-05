using System.ComponentModel.DataAnnotations;

namespace eshop.API
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

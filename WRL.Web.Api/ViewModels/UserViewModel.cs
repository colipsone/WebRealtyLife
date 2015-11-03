using System.ComponentModel.DataAnnotations;

namespace WRL.Web.Api.ViewModels
{
    public class UserViewModel
    {
        [Required]
        [Display(Name = "Имя Пользователя")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} должен быть длиной не менее {2} символов.", MinimumLength = 1)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение Пароля")]
        [Compare("Password", ErrorMessage = "Пароль и Подтверждение Пароля не совпадают.")]
        public string ConfirmPassword { get; set; }
    }
}
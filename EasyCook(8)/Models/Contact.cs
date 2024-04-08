using System.ComponentModel.DataAnnotations;

namespace EasyCook.Models
{
    public class Contact
    {
        [Key]

        [Display(Name=" Имя")]
        [Required (ErrorMessage="Вам нужно ввести имя")]
        public string Name { get; set; }

        [Display(Name = " Фамилия")]
        [Required(ErrorMessage = "Вам нужно ввести фамилия")]
        public string Surname { get; set; }

        [Display(Name = " Возраст")]
        [Required(ErrorMessage = "Вам нужно ввести возраст")]
        public int Age { get; set; }

        [Display(Name = " Почта")]
        [Required(ErrorMessage = "Вам нужно ввести почту")]
        public string Email { get; set; }

        [Display(Name = " Сообщение")]
        [Required(ErrorMessage = "Вам нужно ввести сообщение")]
        [StringLength(400, ErrorMessage="Текст должен быть менее 30 символов")]
        public string Message { get; set; }
    }
}

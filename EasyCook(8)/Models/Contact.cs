using System.ComponentModel.DataAnnotations;

namespace EasyCook.Models
{
    public class Contact
    {
        [Key]

        [Display(Name="Введите имя")]
        [Required (ErrorMessage="Вам нужно ввести имя")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилия")]
        [Required(ErrorMessage = "Вам нужно ввести фамилия")]
        public string Surname { get; set; }

        [Display(Name = "Введите возраст")]
        [Required(ErrorMessage = "Вам нужно ввести возраст")]
        public int Age { get; set; }

        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Вам нужно ввести почту")]
        public string Email { get; set; }

        [Display(Name = "Введите сообщение")]
        [Required(ErrorMessage = "Вам нужно ввести сообщение")]
        [StringLength(400, ErrorMessage="Текст должен быть менее 30 символов")]
        public string Message { get; set; }
    }
}

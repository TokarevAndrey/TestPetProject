using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplication6.Models
{
    public class GuestResponse
    {   [Required(ErrorMessage ="Введите имя")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Введите адресс электронной почты")]
        [RegularExpression(".+\\@.+.\\..+",
            ErrorMessage ="Введите коректный адресс электронной почты")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Введите номер телефона")]
        public string Phone  { get; set; }
        [Required(ErrorMessage ="Определитесь с выбором")]
        public bool? WillAttend { get; set; }
    }
}

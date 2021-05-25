using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public class Sign_Up
    {
        public int ID { get; set; }
       // [Required(ErrorMessage = "Name is Requirde"), MaxLength(20)]
        //[RegularExpression(@"^[A-Z][a-zA-Z]*$", ErrorMessage = "Name is not in Format.")]
        public string Name { get; set; }


        //[Required(ErrorMessage = "Email is Requird"), MaxLength(30)]
        //[RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }

        //[Required(ErrorMessage = " Mobile Number is Requird"), MaxLength(14)]
        //[RegularExpression(@"^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$", ErrorMessage = "Phone is not in Format.")]
        public string Phone { get; set; }

        public String Password { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduits.Service
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Email id est obligatoire.")]
        public string  Email { get; set; }
        [Required(ErrorMessage = "Password id est obligatoire.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

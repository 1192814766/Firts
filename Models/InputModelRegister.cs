using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SalesSystem.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "El campo Nombre es obligatorio. ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio. ")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo ID es obligatorio. ")]
        public string id { get; set; }

        [Required(ErrorMessage = "El campo Telefono es obligatorio. ")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"\(?[0-9]{2})/)?[-. ]?([0-9]){2})[-. ]?([0-9]){9})$", ErrorMessage = " <font color = 'red'> El formato de telefono ingresado no es valido. ")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = " El Campo Correo es obligatorio. ")]
        [EmailAddress(ErrorMessage = "Los datos ingresados no son una direccion de correo electronico valido. ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo Contraseña es obligatorio. ")]
        [Display(Name = "Contraseña")]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 8)]
        public string Password { get; set; }
    }
}

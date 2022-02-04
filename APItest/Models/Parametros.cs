using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APItest.Models
{
    public class Parametros
    {
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MinLength(2, ErrorMessage = "El campo {0} debe contener {1} digitos.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El campo {0} debe contener números.")]
        public string Nombre { get; set; }
        
    }
}

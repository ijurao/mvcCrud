using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramwork.Models
{
    public class Usuario
    {

        //siempre se necesita una identidad
        [Key]
 
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [Display(Name = "Nombre de Usuario")]

        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo telefono es obligatorio es obligatorio")]
        [Display(Name = "Telefono")]

        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo Celular es obligatorio es obligatorio")]
        [Display(Name = "Telefono Celular")]

        public string Celular { get; set; }
        [Required(ErrorMessage = "El campo Email es obligatorio es obligatorio")]
        [EmailAddress]
        public string Email { get; set; }
    }
}

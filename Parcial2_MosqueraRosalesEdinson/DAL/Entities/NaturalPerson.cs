using System.ComponentModel.DataAnnotations;

namespace Parcial2_MosqueraRosalesEdinson.DAL.Entities
{     // primer tabla 
    public class NaturalPerson : Entity
    {
        [Required(ErrorMessage = "El campo{0} es Obligatorio")]

        [Display(Name = "Nombre Y Apellidos")]

        [MaxLength(60,ErrorMessage ="El campo {0} debe tener Maximo{1} caracteres")]

        public string FullName { get; set; }

        [Required(ErrorMessage = "El campo{0} es Obligatorio")]

        [Display(Name = "Correo Electronico")]

        [MaxLength(80, ErrorMessage = "El campo {0} debe tener Maximo{1} caracteres")]

        public string Email { get; set; }

        [Required(ErrorMessage = "El campo{0} es Obligatorio")]

        [Display(Name = "Fecha de Nacimiento")]
        public DateTime? BirtYear { get; set; }

        [Display(Name = "Edad")]

        public int Age { get; set; }
    }
}

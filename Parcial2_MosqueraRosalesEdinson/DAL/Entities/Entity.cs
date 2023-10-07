using System;
using System.ComponentModel.DataAnnotations;

namespace Parcial2_MosqueraRosalesEdinson.DAL.Entities
{
    public class Entity
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Fecha de Creacion")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Fecha de Modificacion")]
        public DateTime? ModifieldDate { get; set; }

    }
}

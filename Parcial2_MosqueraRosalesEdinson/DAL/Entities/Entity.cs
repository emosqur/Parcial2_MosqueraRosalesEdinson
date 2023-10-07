using System;
using System.ComponentModel.DataAnnotations;

namespace Parcial2_MosqueraRosalesEdinson.DAL.Entities
{
    public class Entity
    {
        [Required]
        public Guid Id { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifieldDate { get; set; }

    }
}

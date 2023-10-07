using System;

namespace Parcial2_MosqueraRosalesEdinson.DAL.Entities
{
    public class Entity
    {
        public Guid Id { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string FullName { get; set;}

        public string  Email { get; set;}

        public DateTime? BirtYear { get; set; }

        public int  Age { get; set;}

    }
}

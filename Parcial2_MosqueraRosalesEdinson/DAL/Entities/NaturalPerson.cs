namespace Parcial2_MosqueraRosalesEdinson.DAL.Entities
{     // primer tabla 
    public class NaturalPerson : Entity
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public DateTime? BirtYear { get; set; }

        public int Age { get; set; }
    }
}

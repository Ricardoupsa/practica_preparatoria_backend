
namespace practica_preparatoria.Models
{
    using System.Data.Entity;
    public class DataContext :DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<practica_preparatoria.Models.Student> Students { get; set; }
    }
}
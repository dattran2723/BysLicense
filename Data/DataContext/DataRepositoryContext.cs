using System.Data.Entity;

namespace Data.DataContext
{
    public class DataRepositoryContext : DbContext
    {
        public DataRepositoryContext()
            : base("DbConnection")
        { }

        public System.Data.Entity.DbSet<Data.Entities.Project> Projects { get; set; }
    }
}

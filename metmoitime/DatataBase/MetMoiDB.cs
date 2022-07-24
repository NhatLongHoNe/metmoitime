using metmoitime.EF;
using Microsoft.EntityFrameworkCore;

namespace metmoitime.DatataBase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Test_Table> TestTable => Set<Test_Table>();
    }
}

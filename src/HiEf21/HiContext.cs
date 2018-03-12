using Microsoft.EntityFrameworkCore;

namespace HiEf21 {
    public class HiContext : DbContext {
        private string connectionString;
        public HiContext(string connectionString) => this.connectionString = connectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            builder.UseNpgsql(connectionString);
        }
        public DbSet<Student> Students { set; get; }
    }
}

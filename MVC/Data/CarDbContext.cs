namespace MVC.Data
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options)
        {

        }
        public DbSet<Car> cars { get; set; }
    }
}

namespace Datingapp.api.Data
{
    using Microsoft.EntityFrameworkCore;
    using  Datingapp.api.Models;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : 
        base(options){

        }

        public DbSet<Value> Values { get; set; }
    }
}
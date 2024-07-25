using Homework5_CV.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework5_CV.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options){}

        public DbSet<DataModel> CV { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Recall_Project.Entities;

namespace Recall_Project.Context
{
    public class SampleContext:DbContext
    {
        public SampleContext(DbContextOptions options):base(options)
        {
        }  
        public DbSet<Products> Products { get; set; }
    }
}

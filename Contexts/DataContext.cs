using Crito_project.Models;
using Microsoft.EntityFrameworkCore;

namespace Crito_project.Contexts;


// DataContext
public class DataContext : DbContext
{
    public DataContext()
    {
        
    }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<ContactFormEntity> ContactUsForm { get; set; }
}

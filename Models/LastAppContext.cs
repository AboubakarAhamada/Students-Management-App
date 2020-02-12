using System; 
using Microsoft.EntityFrameworkCore; 
  
namespace LastApp.Models 
{ 
public class LastAppContext : DbContext 
{ 
    public LastAppContext(DbContextOptions<LastAppContext> options) 
            : base(options) 
    { 
    } 
  
    public DbSet<Student> Student { get; set; } 
} 
}
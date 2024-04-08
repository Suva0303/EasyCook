using EasyCook.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyCook_8_.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
            
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}

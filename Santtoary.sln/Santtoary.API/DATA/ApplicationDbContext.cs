using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Santtoary.Shared.Entidades;
using Santtooary.Shared.Entidades;

namespace Santtoary.API.DATA
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Design> Designs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Client> Clients { get; set; }


    }

}

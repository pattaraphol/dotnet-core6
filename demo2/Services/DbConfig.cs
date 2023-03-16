using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using demo2.Models;

namespace demo2.Services
{
    public class DbConfig : DbContext
    {
        public DbConfig(DbContextOptions<DbConfig> options) : base(options) { }

        public DbSet<NoteModels> Notes { get; set; }
    }



}

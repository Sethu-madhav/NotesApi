using Microsoft.EntityFrameworkCore;
using NotesApi.Models.Entities;

namespace NotesApi.Data
{
    public class NotesDbContext : DbContext
    {
        public NotesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}

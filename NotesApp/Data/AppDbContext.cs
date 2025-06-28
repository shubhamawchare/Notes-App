using Microsoft.EntityFrameworkCore;
using NotesApp.Models;
using System.Collections.Generic;

namespace NotesApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
    }
}

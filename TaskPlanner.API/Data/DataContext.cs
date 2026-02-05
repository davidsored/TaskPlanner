using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using TaskPlanner.API.Models;     

namespace TaskPlanner.API.Data { 
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Tarea> Tareas { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
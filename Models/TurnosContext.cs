namespace TurnosApp.Models
{
    using System;    
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;    

    public class TurnosContext : DbContext
    {
        public TurnosContext(DbContextOptions<TurnosContext> options) : base(options)
        {
        }
        public DbSet<Specialty> Specialties { get; set; }
        
    }
}
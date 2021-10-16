using System;
using Microsoft.EntityFrameworkCore;

namespace curzi.lorenzo._5h.PrimoEF.Models
{
    public class DbPersone : DbContext
    {
        //Tabella di Persone
        public DbSet<Persona> Persone { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opzioni)
        {
            opzioni.UseSqlite("DataSource=dbPersone.db");
        }

    }
}
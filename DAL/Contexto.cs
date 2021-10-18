using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6RegistroConDetalleDesdeCero.Entidades;

namespace Tarea6RegistroConDetalleDesdeCero.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permisos> Permiso { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"data Source = data\rolescontrol.Db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permisos>().HasData(
                new Permisos { PermisoId = 1, Nombre = "Usuario", Descripcion = "Para usuarios" },
                new Permisos { PermisoId = 2, Nombre = "Administrador", Descripcion = "Para administradores" });
        }
    }
}

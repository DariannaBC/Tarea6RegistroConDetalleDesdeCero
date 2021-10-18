using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6RegistroConDetalleDesdeCero.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public int RolId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Alias { get; set; }
        public string Nombres { get; set; }
        public bool Activo { get; set; }

        public Usuarios()
        {
            RolId = 0;
            UsuarioId = 0;
            FechaIngreso = DateTime.Now;
            Alias = string.Empty;
            Nombres = string.Empty;
            Activo = false;
        }

        public Usuarios(int rolId, int usuarioId, DateTime fechaIngreso, string alias, string nombres, bool activo)
        {
            RolId = rolId;
            UsuarioId = usuarioId;
            FechaIngreso = fechaIngreso;
            Alias = alias;
            Nombres = nombres;
            Activo = activo;
        }
    }
}

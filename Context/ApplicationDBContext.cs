using Microsoft.EntityFrameworkCore;
using Proyecto23CV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto23CV.Context
{
    public class ApplicationDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL("server= localhost; database=ProyectoDb23CV; user=root; password=");
        }

        public DbSet<Rol>Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}

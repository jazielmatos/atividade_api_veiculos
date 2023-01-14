using atividade_api_web.Models;
using Microsoft.EntityFrameworkCore;

namespace atividade_api_web.Context
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

        public DbSet<Administrador> Administradores { get; set; }
    }
}

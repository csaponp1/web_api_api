using Microsoft.EntityFrameworkCore;

namespace web_api.Models
{
    class Conexion : DbContext{
        public Conexion (DbContextOptions<Conexion> options) : base (options){}
        public DbSet<Clientes> Clientes {get;set;}
        
    }
    
    class Conectar{
        private const string cadenaConexion="server=localhost;port=3306;database=db_empresa_2022;userid=usr_empresa_3;pwd=lasviejas!123";
        public static Conexion Create(){
            var constructor = new DbContextOptionsBuilder<Conexion>();
            
            constructor.UseMySQL(cadenaConexion);
            var cn = new Conexion(constructor.Options);
            return cn;
        }
    }
}
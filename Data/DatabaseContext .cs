using Microsoft.EntityFrameworkCore;
using RestApi.Models;

namespace RestApi.Data
{
    public class DatabaseContext:DbContext
    {
        //database içindeki tabloları tanitalim  
        public DatabaseContext (DbContextOptions<DatabaseContext> opt):base(opt)
        {
            
        } 

        public DbSet<Posts> posts {get;set;}
    }
}
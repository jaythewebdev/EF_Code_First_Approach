using Microsoft.EntityFrameworkCore;
using Users;

namespace UserContext
{
    public class UsersContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-1J0KOR9F\\SQLSERVER2023JAI;Integrated Security=true;Initial Catalog=dbuserlogin");

        }
        public DbSet<User> Users { get; set; }
      


    }
}
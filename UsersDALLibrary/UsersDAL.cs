using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UserContext;
using Users;

using Users;

namespace UsersDALLibrary
{
    public class UsersDAL : IRepo<User, int>
{
         UsersContext context=new UsersContext();
        


        public void Get(int id)
        {
            Console.WriteLine("The user details are ");
            Console.WriteLine("");
            var users = (from u in context.Users
                          where u.Id == id select u).ToList();
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }

        }

        public void GetAll()
        {

            Console.WriteLine("The Users in the database are :");
            Console.WriteLine("");
            var users = (from u in context.Users select u).ToList();
            string pass="";
            foreach (var user in users)
            {

                Console.WriteLine(user);
                
            }



        }
        public bool Add(User item)
        {
            User user = new User();
            user.Name = item.Name;
            user.Password= item.Password;
            user.Type=item.Type;
            context.Users.Add(user);
            context.SaveChanges();

            return true;

        }
        public User login(string username , string password)
        {  
            User user = new User();
            var users = (from u in context.Users select u).ToList();
            foreach (var user1 in users)
            {
                if (user1.Name == username && user1.Password==password) {
                    Console.WriteLine("you are successfully logged in");
                    return user1;
                }
            }
            return user;
        }
    }
}

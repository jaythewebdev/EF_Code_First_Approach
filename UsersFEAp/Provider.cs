using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersBLLibrary;
using UsersDALLibrary;
using Users;
using UsersBLLibrary;
using static System.Formats.Asn1.AsnWriter;
using System.Runtime.Intrinsics.X86;

namespace UsersFEAp
{
    internal class Provider
    {
        ManageUser manage;
        IRepo<User, int> userRepo;
        public Provider()
        {
            userRepo = new UsersDAL();
            manage = new ManageUser(userRepo);
           
        }


        public void MainMenu()
        {

            int choice;
            do
            {
                Console.WriteLine("--------------");
                Console.WriteLine("Choose the Type of User ");
                Console.WriteLine("1.New User\n2.Registered User\n0.Exit");
                while(!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice");

                }

                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        Add();
                        break;
                    case 2:
                        Login();
                        break;
                  
                    default:
                        Console.WriteLine("Enter a Valid Choice ");
                        break;

                }
            } while (choice != 0);
        }

        public void ViewAllUsers()
        {
            manage.GetAll();

        }
        public void ViewParticularUser()
        {
            Console.WriteLine("Enter the user id to view details");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid Entry.ID must be an integer ");
            }
                manage.Get(id);

        }
        public void Login()
        {
            Console.WriteLine("Enter User Name");
            string username = Console.ReadLine();
            Console.WriteLine("Enter the password ");
            string password = Console.ReadLine();
            User user =manage.login(username, password);
            if (user.Type == "User")
            {
                Console.WriteLine("Enter 1 to view Your UserDetails");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine(user);
                }
                else
                {
                    Console.WriteLine("Invalid choice.Returned to Main Menu");
                }
            }
            else if (user.Type == "Admin")
            {
                Console.WriteLine("Enter 1 to View All Users Details");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    ViewAllUsers();
                }
                else
                {
                    Console.WriteLine("Returned to Main Menu");
                }
            }
            else
            {
                Console.WriteLine("You are not a valid user");
            }
        }
        public void Add()
        {
            User user = new User();
            user.TakeDetails();

            if (manage.Add(user))
            {
                Console.WriteLine("User details are added Successfully");
            }
            else
            {
                Console.WriteLine("Adding user details Failed ");
            }


        }


    }
}

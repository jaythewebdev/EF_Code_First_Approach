namespace Users
{
    public class User
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }

        public string? Type { get; set; }

        string pass;
     


        public void TakeDetails()
        {
            Console.WriteLine("Enter your username");
            Name=Console.ReadLine();
            Console.WriteLine("Enter your Password ");
            Password=Console.ReadLine();
            Console.WriteLine("Enter user type");
            Console.WriteLine("1.User 2.Admin");
            Type=Console.ReadLine();

        }
        public override string ToString()
        {
            for (int i = 0; i < Password.Length; i++)
            {
                if (i == 0 || i == Password.Length - 1)
                {
                    pass += Password[i];
                }
                else
                {
                    pass += "*";
                }
            }
            string message = "" ;
            message += $"\n User Details " ;
            message += $"\n---------------------- - ";
            message += $"\n User Id : {Id}";
            message += $"\n User Name : {Name}";
            message += $"\n Password : {pass}";
            message += $"\n User Type :{Type}";

            return message;
        }
    }
}
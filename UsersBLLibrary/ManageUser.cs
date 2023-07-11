using UsersDALLibrary;
using Users;
namespace UsersBLLibrary
{
    public class ManageUser
    {

        private readonly IRepo<User,int>_repo;
        public ManageUser()
        {
        }
        public ManageUser(IRepo<User,int> repo)
{

        _repo = repo;
}

    


    public void GetAll()
    {
        _repo.GetAll();
    }
 
    public void Get(int id)
    {
       _repo.Get(id);
    }

    public User  login(string username, string password)
        {
           return  _repo.login(username, password);
        }
        public bool Add(User user)
        {
            return _repo.Add(user);
        }
}
}
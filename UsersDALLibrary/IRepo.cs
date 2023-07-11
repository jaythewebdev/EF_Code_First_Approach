
using Users;
namespace UsersDALLibrary

{
    public interface IRepo<T, K>
    {
        void  GetAll();
        void  Get(K id);
        User login(string username, string password);
        bool Add(User item);
    }

}
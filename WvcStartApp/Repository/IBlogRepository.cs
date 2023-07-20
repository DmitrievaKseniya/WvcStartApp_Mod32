using System.Threading.Tasks;
using WvcStartApp.Models.Db;

namespace WvcStartApp.Repository
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
        Task<User[]> GetUsers();
    }
}

using System.Threading.Tasks;
using WvcStartApp.Models.Db;

namespace WvcStartApp.Repository
{
    public interface ILogRepository
    {
        Task AddLog(Request request);

        Task<Request[]> GetLogs();
    }
}

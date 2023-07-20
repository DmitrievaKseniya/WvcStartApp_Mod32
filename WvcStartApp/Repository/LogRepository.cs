using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using WvcStartApp.Models.Db;
using System.Linq;

namespace WvcStartApp.Repository
{
    public class LogRepository : ILogRepository
    {
        // ссылка на контекст
        private readonly BlogContext _context;

        // Метод-конструктор для инициализации
        public LogRepository(BlogContext context)
        {
            _context = context;
        }
        public async Task AddLog(Request request)
        {
            request.Id = Guid.NewGuid();

            // Добавление пользователя
            var entry = _context.Entry(request);
            if (entry.State == EntityState.Detached)
                await _context.Requests.AddAsync(request);

            // Сохранение изенений
            await _context.SaveChangesAsync();
        }
        public async Task<Request[]> GetLogs()
        {
            // Получим все логи
            return await _context.Requests.OrderByDescending(x => x.Date).ToArrayAsync();
        }
    }
}

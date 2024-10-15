using Microsoft.EntityFrameworkCore;
using PracticeWebApi.Models;

namespace PracticeWebApi.Data
{
    public interface IAppDbContext : IDbContext
    {
        DbSet<User> Users { get; set; }
    }
}

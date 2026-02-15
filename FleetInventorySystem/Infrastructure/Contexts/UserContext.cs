using Fleet_Inventory_System.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Fleet_Inventory_System.Infrastructure.Contexts;

public class UserContext(DbContextOptions<UserContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}

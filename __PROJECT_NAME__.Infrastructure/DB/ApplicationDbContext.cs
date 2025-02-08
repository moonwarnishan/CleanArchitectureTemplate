using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace __PROJECT_NAME__.Infrastructure.DB;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<>(options)
{
}
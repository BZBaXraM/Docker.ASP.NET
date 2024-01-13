using Microsoft.EntityFrameworkCore;
using MiniMvcCmsApp.Models;

namespace MiniMvcCmsApp.Data;

public sealed class CmsContext : DbContext
{
    public CmsContext(DbContextOptions<CmsContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    public DbSet<OrderViewModel> Orders => Set<OrderViewModel>();
}
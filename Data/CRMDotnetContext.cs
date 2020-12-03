using Microsoft.EntityFrameworkCore;
using CRMDotnet.Models;

namespace CRMDotnet.Data
{
    public class CRMDotnetContext : DbContext
    {
        public CRMDotnetContext (DbContextOptions<CRMDotnetContext> options)
        : base(options)
        {

        }
        public DbSet<Cliente> Cliente {get; set;}
    }
}
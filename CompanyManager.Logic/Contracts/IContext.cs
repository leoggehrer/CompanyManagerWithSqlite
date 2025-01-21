using Microsoft.EntityFrameworkCore;

namespace CompanyManager.Logic.Contracts
{
    public interface IContext : IDisposable
    {
        DbSet<Entities.Company> CompanySet { get; }
        DbSet<Entities.Customer> CustomerSet { get; }

        int SaveChanges();
    }
}
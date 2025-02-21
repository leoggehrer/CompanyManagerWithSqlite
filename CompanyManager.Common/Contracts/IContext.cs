//@BaseCode
namespace CompanyManager.Common.Contracts
{
    /// <summary>
    /// Represents a context that manages the connection to the database and provides methods to save changes.
    /// </summary>
    public interface IContext : IDisposable
    {

        /// <summary>
        /// Saves all changes made in this context to the database.
        /// </summary>
        /// <returns>The number of state entries written to the database.</returns>
        int SaveChanges();
    }
}
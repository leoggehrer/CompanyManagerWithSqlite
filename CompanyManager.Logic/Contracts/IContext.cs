﻿using Microsoft.EntityFrameworkCore;

namespace CompanyManager.Logic.Contracts
{
    /// <summary>
    /// Represents a context that manages the connection to the database and provides methods to save changes.
    /// </summary>
    public interface IContext : IDisposable
    {
        #region Properties
        DbSet<Entities.Company> CompanySet { get; }
        DbSet<Entities.Customer> CustomerSet { get; }
        DbSet<Entities.Employee> EmployeeSet { get; }
        #endregion Properties

        #region Methods
        /// <summary>
        /// Saves all changes made in this context to the database.
        /// </summary>
        /// <returns>The number of state entries written to the database.</returns>
        int SaveChanges();
        #endregion Methods
    }
}
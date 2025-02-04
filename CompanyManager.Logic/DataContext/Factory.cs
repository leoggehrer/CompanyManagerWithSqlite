using CompanyManager.Logic.Contracts;

namespace CompanyManager.Logic.DataContext
{
    /// <summary>
    /// Factory class to create instances of IMusicStoreContext.
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Creates an instance of IContext.
        /// </summary>
        /// <returns>An instance of IContext.</returns>
        public static IContext CreateContext()
        {
            var result = new CompanyContext();

            return result;
        }

#if DEBUG
        public static void CreateDatabase()
        {
            var context = new CompanyContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        public static void InitDatabase()
        {
            var path = "Data";
            var context = CreateContext();

            CreateDatabase();

            var companies = DataLoader.LoadCompaniesFromCsv(Path.Combine(path, "companies.csv"));

            companies.ToList().ForEach(e => context.CompanySet.Add(e));
            context.SaveChanges();

            var customers = DataLoader.LoadCustomersFromCsv(Path.Combine(path, "customers.csv"));
            customers.ToList().ForEach(e => context.CustomerSet.Add(e));

            var employees = DataLoader.LoadEmployeesFromCsv(Path.Combine(path, "employees.csv"));
            employees.ToList().ForEach(e => context.EmployeeSet.Add(e));

            context.SaveChanges();
#endif
        }
    }
}

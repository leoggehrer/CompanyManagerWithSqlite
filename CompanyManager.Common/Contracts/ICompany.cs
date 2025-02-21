//@BaseCode
namespace CompanyManager.Common.Contracts
{
    /// <summary>
    /// Represents a company in the company manager.
    /// </summary>
    public interface ICompany : IIdentifiable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Gets or sets the address of the company.
        /// </summary>
        string? Address { get; set; }
        #endregion Properties

        #region Methods
        /// <summary>
        /// Copies the properties of the specified company to this company.
        /// </summary>
        /// <param name="company">The company object that is copied.</param>
        void CopyProperties(ICompany company)
        {
            Id = company.Id;
            Name = company.Name;
            Address = company.Address;
        }
        #endregion Methods
    }
}

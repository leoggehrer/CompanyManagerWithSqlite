using CompanyManager.Logic.Contracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyManager.Logic.Entities
{
    [Table("Companies")]
    [Index(nameof(Name), IsUnique = true)]
    public class Company : EntityObject, ICompany
    {
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(1024)]
        public string? Address { get; set; }
        [MaxLength(2048)]
        public string? Description { get; set; }

        #region navigation properties
        public List<Customer> Customers { get; set; } = [];
        #endregion navigation properties

        public void CopyProperties(ICompany company)
        {
            base.CopyProperties(company);

            Name = company.Name;
            Address = company.Address;
            Description = company.Description;
        }

        public override string ToString()
        {
            return $"Company: {Name}";
        }
    }
}

using CompanyManager.Logic.Contracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyManager.Logic.Entities
{
    [Table("Customers")]
    [Index(nameof(Name), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class Customer : EntityObject, ICustomer
    {
        public int CompanyId { get; set; }
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(128)]
        public string Email { get; set; } = string.Empty;

        public Company? Company { get; set; }

        public void CopyProperties(ICustomer customer)
        {
            base.CopyProperties(customer);

            CompanyId = customer.CompanyId;
            Name = customer.Name;
            Email = customer.Email;
        }
        public override string ToString()
        {
            return $"Customer: {Name}";
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace GarageManagement.SampleData.Models;

public class IndividualCustomer
{
    public int CustomerId { get; set; }

    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    public string LastName { get; set; } = string.Empty;

    public Customer Customer { get; set; } = null!;
}

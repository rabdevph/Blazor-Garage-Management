using System.ComponentModel.DataAnnotations;

namespace GarageManagement.SampleData.Models;

public class CompanyCustomer
{
    public int CustomerId { get; set; }

    [Required]
    public string CompanyName { get; set; } = string.Empty;

    public string? ContactPerson { get; set; }

    public string? Position { get; set; }

    public Customer Customer { get; set; } = null!;
}

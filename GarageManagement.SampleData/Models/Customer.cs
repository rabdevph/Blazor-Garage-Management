using System.ComponentModel.DataAnnotations;
using GarageManagement.SampleData.Enums;

namespace GarageManagement.SampleData.Models;

public class Customer
{
    public int Id { get; set; }

    public CustomerType Type { get; set; }

    [Required]
    public string PhoneNumber { get; set; } = string.Empty;

    public string? Address { get; set; }

    public string? Notes { get; set; }

    public CustomerStatus Status { get; set; } = CustomerStatus.Active;

    public IndividualCustomer? IndividualCustomer { get; set; }
    public CompanyCustomer? CompanyCustomer { get; set; }
    public List<VehicleOwnership> VehicleOwnerships { get; set; } = [];
}

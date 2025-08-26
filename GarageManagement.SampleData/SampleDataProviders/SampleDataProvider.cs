using GarageManagement.SampleData.Enums;
using GarageManagement.SampleData.Models;

namespace GarageManagement.SampleData.SampleDataProviders;

public static class SampleDataProvider
{
    public static List<Vehicle> SampleVehicles { get; } =
    [
        new Vehicle
        {
            Id = 1,
            Make = "Toyota",
            Model = "Camry",
            Year = 2020,
            Vin = "1HGBH41JXMN109186",
            LicensePlate = "ABC123",
            Color = "Blue"
        },
        new Vehicle
        {
            Id = 2,
            Make = "Honda",
            Model = "Accord",
            Year = 2019,
            Vin = "1HGCM82633A123456",
            LicensePlate = "XYZ789",
            Color = "Black"
        },
        new Vehicle
        {
            Id = 3,
            Make = "Ford",
            Model = "Mustang",
            Year = 2021,
            Vin = "1FAFP45X8F1234567",
            LicensePlate = "LMN456",
            Color = "Red",
            Notes = "Minor scratch on rear bumper"
        }

    ];


    public static List<Customer> SampleCustomers { get; } =
    [
        new Customer
        {
            Id = 1,
            Type = CustomerType.Individual,
            PhoneNumber = "123-456-7890",
            Address = "123 Main St, Anytown, USA",
            Notes = "First-time customer",
            Status = CustomerStatus.Active,
            IndividualCustomer = new IndividualCustomer
            {
                FirstName = "John",
                LastName = "Doe"
            }
        },
        new Customer
        {
            Id = 2,
            Type = CustomerType.Company,
            PhoneNumber = "987-654-3210",
            Address = "456 Corporate Blvd, Business City, USA",
            Notes = "VIP customer",
            Status = CustomerStatus.Active,
            CompanyCustomer = new CompanyCustomer
            {
                CompanyName = "Tech Innovations LLC",
                ContactPerson = "Jane Smith"
            }
        }
    ];

    public static List<VehicleOwnership> SampleVehicleOwnerships { get; } =
    [
        new VehicleOwnership
        {
            Id = 1,
            VehicleId = 1,
            CustomerId = 1,
            IsCurrentOwner = true
        },
        new VehicleOwnership
        {
            Id = 2,
            VehicleId = 2,
            CustomerId = 2,
            IsCurrentOwner = true
        },
        new VehicleOwnership
        {
            Id = 3,
            VehicleId = 3,
            CustomerId = 2,
            IsCurrentOwner = true
        }
    ];
}

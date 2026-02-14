using System.ComponentModel.DataAnnotations;

namespace Fleet_Inventory_System.Domain.Users;

public class User
{
    public required string Id { get; set; }
    public string Name { get; private set; } = "";
    public string TechNumber { get; private set; } = "";
    public string EmployeeNumber { get; private set; } = ""; // used as password, will be hashed in the future
    public UserRoles Role { get; private set; } = UserRoles.Technician;
}

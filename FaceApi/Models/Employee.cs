using System.ComponentModel.DataAnnotations;

namespace FaceApi.Models;

public class Employee
{
    [Key]
    public int Id { get; set; }
    public string? EmployeeId { get; set; }
    public string Name { get; set; }
}
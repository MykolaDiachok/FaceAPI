using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaceApi.Models;

public class FaceMetadata
{
    [Key]
    public int Id { get; set; }

    public string? EmployeeId { get; set; }
    public string? CustomerId { get; set; }
    public  Gender? Gender { get; set; }
    public int? Age { get; set; }
    public required string ImagePath { get; set; }
    
    [ForeignKey("EmployeeId")]
    public Employee? Employee { get; set; }

    [ForeignKey("CustomerId")]
    public Customer? Customer { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaceApi.Models;

public class FaceVector
{
    [Key]
    public int Id { get; set; }
    public string? EmployeeId { get; set; }
    public string? CustomerId { get; set; }
    public float[] FaceVectors { get; set; }= [];
    
    [ForeignKey("EmployeeId")]
    public Employee? Employee { get; set; }

    [ForeignKey("CustomerId")]
    public Customer? Customer { get; set; }
}
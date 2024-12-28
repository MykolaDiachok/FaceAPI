using System.ComponentModel.DataAnnotations;

namespace FaceApi.Models;

public class Customer
{
    [Key]
    public int Id { get; set; }
    public string? CutomerId { get; set; }
    public string Name { get; set; }
}
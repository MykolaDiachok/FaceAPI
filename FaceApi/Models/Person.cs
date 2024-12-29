using System.ComponentModel.DataAnnotations;

namespace FaceApi.Models;

public class Person
{
    [Key]
    public int Id { get; set; }
    [MaxLength(36, ErrorMessage = "The IndividualId cannot exceed 36 characters.")]
    public string? IndividualId { get; set; }
    [MaxLength(1024, ErrorMessage = "The Name cannot exceed 1024 characters.")]
    public string? Name { get; set; }
}
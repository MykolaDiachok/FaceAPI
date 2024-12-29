using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaceApi.Models;

public class FaceMetadata
{
    [Key]
    public int Id { get; set; }

    [MaxLength(36, ErrorMessage = "The IndividualId cannot exceed 36 characters.")]
    public string? IndividualId { get; set; }
    public  Gender? Gender { get; set; }
    public int? Age { get; set; }
    
    [MaxLength(1024, ErrorMessage = "The ImagePath cannot exceed 1024 characters.")]
    public required string ImagePath { get; set; }
    
    [ForeignKey("IndividualId")]
    public Person? Person { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace FaceApi.Models;

public class FaceRecognitionEvent
{
    [Key]
    public int Id { get; set; }
    [MaxLength(36, ErrorMessage = "The individual Id cannot exceed 36 characters.")]
    public string? IndividualId { get; set; }  
    public required DateTime DateTime { get; set; }
    public required string RecognitionType { get; set; }
    [MaxLength(36, ErrorMessage = "The CameraId cannot exceed 36 characters.")]
    public required string CameraId { get; set; } 
}
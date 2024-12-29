using System.ComponentModel.DataAnnotations;

namespace FaceApi.Models;

public class Camera
{
    [Key]
    [MaxLength(36, ErrorMessage = "The CameraId cannot exceed 36 characters.")]
    public required string CameraId { get; set; } 
    [MaxLength(1024, ErrorMessage = "The CameraName cannot exceed 1024 characters.")]
    public required string CameraName { get; set; }
    [MaxLength(1024, ErrorMessage = "The Location cannot exceed 1024 characters.")]
    public required string Location { get; set; }  
}
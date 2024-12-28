using System.ComponentModel.DataAnnotations;

namespace FaceApi.Models;

public class Camera
{
    [Key]
    public string CameraId { get; set; } 
    public string CameraName { get; set; }
    public string Location { get; set; }  
}
using System.ComponentModel.DataAnnotations;

namespace FaceApi.Models;

public class FaceRecognitionEvent
{
    [Key]
    public int Id { get; set; }
    public int? EmployeeId { get; set; }  
    public int? CustomerId { get; set; }  
    public DateTime DateTime { get; set; }
    public string RecognitionType { get; set; } 
    public string CameraId { get; set; } 
}
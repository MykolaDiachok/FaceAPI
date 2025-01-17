﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaceApi.Models;

public class FaceVector
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(36, ErrorMessage = "The IndividualId cannot exceed 36 characters.")]
    public string? IndividualId { get; set; }
    public float[] FaceVectors { get; set; }= [];
    [ForeignKey("IndividualId")]
    public Person? Person { get; set; }
}
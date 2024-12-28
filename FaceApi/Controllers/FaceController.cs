using FaceApi.Models;
using FaceApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FaceApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FaceController : ControllerBase
{
    private readonly IUsbCameraService _usbCameraService;
    private readonly IFileImageService _fileImageService;
    private readonly IFileService _fileService;
    private readonly IMetadataService _metadataService;
    private readonly string _dataFolder = Path.Combine(Directory.GetCurrentDirectory(), "CapturedFaceImages");

    public FaceController(IUsbCameraService usbCameraService, IFileImageService fileImageService,
        IFileService fileService, IMetadataService metadataService)
    {
        _usbCameraService = usbCameraService;
        _fileImageService = fileImageService;
        _fileService = fileService;
        _metadataService = metadataService;

        if (!Directory.Exists(_dataFolder))
        {
            Directory.CreateDirectory(_dataFolder);
        }
    }

    [HttpPost("capture-from-camera")]
    public IActionResult CaptureFaceDataFromCamera([FromForm] string employeeId, [FromForm] Gender gender,
        [FromForm] int age)
    {
        var frame = _usbCameraService.CaptureFrame();
        if (frame == null)
            return StatusCode(500, "Unable to capture image from camera.");

        try
        {
            var fileName = $"{employeeId}_{gender}_{age}.jpg";
            var filePath = _fileService.SaveFrame(frame, fileName, _dataFolder);


            var metadata = new FaceMetadata
            {
                EmployeeId = employeeId,
                Gender = gender,
                Age = age,
                ImagePath = fileName
            };

            _metadataService.SaveMetadata(metadata);
            return Ok(new { message = "Face data captured successfully.", data = metadata });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error while capturing data: {ex.Message}");
        }
    }

    [HttpPost("capture-from-file")]
    [Consumes("multipart/form-data")]
    [Produces("application/json")]
    public IActionResult CaptureFaceDataFromFile([FromForm] string employeeId, [FromForm] Gender gender,
        [FromForm] int age, IFormFile? imageFile)
    {
        if (imageFile == null || imageFile.Length == 0)
            return BadRequest("No image file uploaded.");

        try
        {
            var imagePath = _fileService.SaveFile(imageFile, _dataFolder);

            var frame = _fileImageService.LoadImageFromFile(imagePath);
            if (frame == null)
                return StatusCode(500, "Unable to load image from file.");

            var metadata = new FaceMetadata
            {
                EmployeeId = employeeId,
                Gender = gender,
                Age = age,
                ImagePath = imageFile.FileName
            };
            _metadataService.SaveMetadata(metadata);
            return Ok(new { message = "Face data captured successfully from file.", data = metadata });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error while processing file: {ex.Message}");
        }
    }
}
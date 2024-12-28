using OpenCvSharp;

namespace FaceApi.Services;

public interface IFileService
{
    string SaveFile(IFormFile file, string folderPath);
    string SaveFrame(Mat frame, string fileName, string folderPath);
}
using OpenCvSharp;

namespace FaceApi.Services;

public class FileService : IFileService
{
    public string SaveFile(IFormFile file, string folderPath)
    {
        var filePath = Path.Combine(folderPath, file.FileName);
        using var stream = new FileStream(filePath, FileMode.Create);
        file.CopyTo(stream);

        return filePath;
    }

    public string SaveFrame(Mat frame, string fileName, string folderPath)
    {
        var filePath = Path.Combine(folderPath, fileName);
        frame.SaveImage(filePath);
        return filePath;
    }
}

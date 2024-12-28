using OpenCvSharp;

namespace FaceApi.Services;

public class FileImageService : IFileImageService
{
    public Mat? LoadImageFromFile(string filePath)
    {
        try
        {
            var image = Cv2.ImRead(filePath, ImreadModes.Color);
            return image.Empty() ? null : image;
        }
        catch
        {
            return null;
        }
    }
}
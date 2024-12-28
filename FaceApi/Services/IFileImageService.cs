using OpenCvSharp;

namespace FaceApi.Services;

public interface IFileImageService
{
    Mat? LoadImageFromFile(string filePath);
}
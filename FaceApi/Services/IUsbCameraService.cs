using OpenCvSharp;

namespace FaceApi.Services;

public interface IUsbCameraService
{
    Mat? CaptureFrame();
}
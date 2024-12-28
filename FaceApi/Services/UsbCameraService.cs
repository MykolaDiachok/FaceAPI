using OpenCvSharp;

namespace FaceApi.Services;

public class UsbCameraService : IUsbCameraService
{
    public Mat? CaptureFrame()
    {
        try
        {
            using var capture = new VideoCapture(0);
            if (!capture.IsOpened())
            {
                return null;
            }

            var frame = new Mat();
            capture.Read(frame);

            if (!frame.Empty()) return frame;
            frame.Dispose();
            return null;

        }
        catch
        {
            return null;
        }
    }
}
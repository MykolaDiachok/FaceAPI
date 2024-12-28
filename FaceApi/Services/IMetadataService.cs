using FaceApi.Models;

namespace FaceApi.Services;

public interface IMetadataService
{
    void SaveMetadata(FaceMetadata metadata);
}
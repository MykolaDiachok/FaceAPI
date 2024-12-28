using FaceApi.DB;
using FaceApi.Models;

namespace FaceApi.Services;

public class MetadataService(FaceDbContext context) : IMetadataService
{
    public void SaveMetadata(FaceMetadata metadata)
    {
        context.FaceMetadatas.Add(metadata);
        context.SaveChanges();
    }
}
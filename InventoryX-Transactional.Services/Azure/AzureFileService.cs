using Azure.Storage.Blobs;
using InventoryX_Transactional.Services.DTOs.Storage;
using InventoryX_Transactional.Services.Exceptions;
using Microsoft.AspNetCore.Http;

namespace InventoryX_Transactional.Services.Azure;

public interface IAzureFileService
{
    Task<BlobFileDTO> UploadFileAsync(string container, IFormFile file);
}

public class AzureFileService : IAzureFileService
{
    private readonly BlobServiceClient _blobServiceClient;

    public AzureFileService(BlobServiceClient blobServiceClient)
    {
        _blobServiceClient = blobServiceClient;
    }

    public async Task<BlobFileDTO> UploadFileAsync(string container, IFormFile file)
    {
        var blobContainer = _blobServiceClient.GetBlobContainerClient(container);
        bool exists = await blobContainer.ExistsAsync();
        if (!exists)
            throw new ResourceNotFoundException($"Container named '{container}' does not exist.");

        var fileId = Guid.NewGuid();
        var extensionFile = Path.GetExtension(file.FileName).ToLower();
        var fileName = $"{fileId}{extensionFile}";

        var blobClient = blobContainer.GetBlobClient($"{fileId}{extensionFile}");

        await using(Stream data = file.OpenReadStream())
        {
            await blobClient.UploadAsync(data);
        }

        return new BlobFileDTO
        {
            Id = fileId,
            FileName = fileName,
            FileUri = blobClient.Uri.AbsoluteUri
        };
    }
}
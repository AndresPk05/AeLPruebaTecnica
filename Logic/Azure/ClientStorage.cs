using Azure.Storage.Blobs;

namespace AeLPruebaTecnica.Logic.Azure;

internal class ClientStorage
{
    public static BlobClient GetBlobClient(string connectionString, string containerName, string blobName)
    {
        var blobServiceClient = new BlobServiceClient(connectionString);
        var containerClient = blobServiceClient.GetBlobContainerClient(containerName);
        return containerClient.GetBlobClient(blobName);
    }
}

using Azure.Storage.Blobs;

namespace AeLPruebaTecnica.Logic.Azure;

internal class Storage
{
    internal void UploadFile(string path)
    {
        try
        {
            BlobClient blobClient = ClientStorage.GetBlobClient(Constants.ConnectionString, Constants.ContainerName, Constants.BlobName);
            var response = blobClient.Upload(path);
            var status = response.GetRawResponse().Status.ToString();
            Console.WriteLine($"This is the status of transaction: {status}");
        }
        catch (Exception)
        {

            Console.WriteLine("Se presento un error subiendo el archivo, revise la cadena de conexion");
        }

    }
}

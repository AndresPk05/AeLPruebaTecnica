using AeLPruebaTecnica.Interface;
using AeLPruebaTecnica.Logic.Azure;

namespace AeLPruebaTecnica.Logic.Strategy;

internal class AzureStrategy : IProcess
{
    Storage storage = new Storage();
    public void ExecuteCase()
    {
        Console.WriteLine("Ejecutando Proceso de Azure Storage");
        //Modificar el path para indicar el archivo que se desea subir
        storage.UploadFile("");
    }
}

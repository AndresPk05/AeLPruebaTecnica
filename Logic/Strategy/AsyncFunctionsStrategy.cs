using AeLPruebaTecnica.Dtos;
using AeLPruebaTecnica.Interface;
using AeLPruebaTecnica.Logic.Async;

namespace AeLPruebaTecnica.Logic.Strategy;

internal class AsyncFunctionsStrategy : IProcess
{
    public void ExecuteCase()
    {
        Console.WriteLine("Ejecutando ejercicio de programacion asincrona");
        AsyncFunctions asyncFunctions = new AsyncFunctions();
        var result = asyncFunctions.Execute(new GenericRequest { File = new FileDto() }).GetAwaiter().GetResult();
        Console.WriteLine(result.Result);
    }
}

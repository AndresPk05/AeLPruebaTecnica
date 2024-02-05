using AeLPruebaTecnica.Interface;
using AeLPruebaTecnica.Logic.Async;

namespace AeLPruebaTecnica.Logic.Strategy;

internal class ParallelFunctionsStrategy : IProcess
{
    public void ExecuteCase()
    {
        Console.WriteLine("Ejecutando ejercicio de programacion paralela");
        ParallelFunctions parallelFunctions = new ParallelFunctions();
        parallelFunctions.Execute().Wait();
    }
}

using AeLPruebaTecnica.Interface;

namespace AeLPruebaTecnica.Logic.Strategy;

internal class ExitProgramStrategy : IProcess
{
    public void ExecuteCase()
    {
        Console.WriteLine("Saliendo del programa");
        Console.Out.Flush();
    }
}

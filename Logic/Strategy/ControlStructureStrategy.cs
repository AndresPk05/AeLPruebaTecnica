using AeLPruebaTecnica.Dtos;
using AeLPruebaTecnica.Interface;

namespace AeLPruebaTecnica.Logic.Strategy;

internal class ControlStructureStrategy : IProcess
{
    public void ExecuteCase()
    {
        Console.WriteLine("Ejecutando ejercicio de estructura de control");
        ControlStructure controlStructure = new ControlStructure();
        controlStructure.execute(new GenericRequest { Number = 10 });
    }
}

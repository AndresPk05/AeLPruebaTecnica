using AeLPruebaTecnica.Interface;
using AeLPruebaTecnica.Logic.Strategy;

Dictionary<int, IProcess> options = new Dictionary<int, IProcess>
{
    { 1, new ControlStructureStrategy() },
    { 2, new CotizanteStrategy() },
    { 3, new AsyncFunctionsStrategy() },
    { 4, new ParallelFunctionsStrategy() },
    { 5, new ExitProgramStrategy() }
};

Console.WriteLine("***************************** Menu Prueba");
Console.WriteLine("Digite el numero equivalente a la opcion que desea utilizar:");
Console.WriteLine("1. Ejercicio de estructura de control");
Console.WriteLine("2. Programacion orientada a objetos");
Console.WriteLine("3. Programacion asincrona");
Console.WriteLine("4. Programacion paralela");
Console.WriteLine("5. Salir");
Console.WriteLine("*****************************");
int option = Convert.ToInt32(Console.ReadLine());
bool exists = options.TryGetValue(option, out IProcess process);
if(!exists)
{
    Console.WriteLine("Opcion no valida");
    return;
}

process.ExecuteCase();
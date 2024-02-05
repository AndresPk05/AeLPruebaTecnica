namespace AeLPruebaTecnica.Logic.Async;

internal class ParallelFunctions
{
    List<int> numbers = new List<int> { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };
    int resultSum = 0;
    public async Task Execute()
    {
        var listTasks = new List<Task>
        {
            Task.Run(() => SumArray()),
            Task.Run(() => PrintResultSum())
        };

        await Task.WhenAll(listTasks);
    }

    public void SumArray()
    {
        numbers.ForEach(n => { 
            resultSum += n;
            // Se agrega Delay para validar que si se ejecutan las dos tareas al tiempo teniendo en cuenta que la suma es tan rapida que no se logra validar la ejecucion de las dos tareas al tiempo.
            Task.Delay(1000);
        });
    }

    public void PrintResultSum()
    {
        while(resultSum < 200)
        {
            Console.WriteLine("El valor aun no llega a 200");
        }

        Console.WriteLine("El valor es igual o mayor a 200");
    }
}

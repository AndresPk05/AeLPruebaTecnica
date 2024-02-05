using AeLPruebaTecnica.Dtos;

namespace AeLPruebaTecnica.Logic;

internal class ControlStructure
{
    private GenericResult<string> Result = new GenericResult<string>();
    public void execute(GenericRequest request)
    {
        Result.Result = GetSingNumber(request.Number);
        Console.WriteLine(Result.Result);
    }

    private string GetSingNumber(int number)
    {
        string result = number > 0 ? "El número es positivo" : "El número es cero o negativo";
        return result;
    }
}

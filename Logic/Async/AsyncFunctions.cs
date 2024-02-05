using AeLPruebaTecnica.Dtos;

namespace AeLPruebaTecnica.Logic.Async;

internal class AsyncFunctions
{
    GenericResult<string> Result = new GenericResult<string>();
    public async Task<GenericResult<string>> Execute(GenericRequest request)
    {
        bool isValid = await ValidateFileAsync(request.File);
        Result.Result = isValid ? "exitoso" : "fallido";
        return Result;
    }

    private async Task<bool> ValidateFileAsync(FileDto file)
    {
        await Task.Delay(10000);
        return true;
    }
}

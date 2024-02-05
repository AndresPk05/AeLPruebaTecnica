namespace AeLPruebaTecnica.Dtos;

internal class GenericResult<T>
{
    public T Result { get; set; }
    public bool Error { get; set; }
    public string Message { get; set; }
}

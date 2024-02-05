namespace AeLPruebaTecnica.Logic.ObjectOrientation;

internal class Cotizante
{
    private string Nombre;

    public string _Nombre
    {
        get { return Nombre; }
        set { if (value.Length <= 30) Nombre = value; }
    }

    private string Apellido;

    public string _Apellido
    {
        get { return Apellido; }
        set { if(value.Length <= 30) Apellido = value; }
    }

    private int TipoCotizante;

    public int _TipoCotizante
    {
        get { return TipoCotizante; }
        set { if(value.ToString().Length >= 2 ) TipoCotizante = value; }
    }

    internal void ImprimirDatosBasicos()
    {
        Console.WriteLine("Los datos del cotizante son:");
        Console.WriteLine($"Nombre: {this.Nombre}, Apellido: {this.Apellido}, TipoCotizante: {this.TipoCotizante}");
    }

}

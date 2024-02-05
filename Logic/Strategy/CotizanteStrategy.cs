using AeLPruebaTecnica.Interface;
using AeLPruebaTecnica.Logic.ObjectOrientation;

namespace AeLPruebaTecnica.Logic.Strategy;

internal class CotizanteStrategy: IProcess
{
    public void ExecuteCase()
    {
        Console.WriteLine("Ejecutando ejercicio de cotizante");
        Cotizante cotizante = new Cotizante();
        cotizante._Nombre = "Juan";
        cotizante._Apellido = "Perez";
        cotizante._TipoCotizante = 10;
        cotizante.ImprimirDatosBasicos();
    }
}

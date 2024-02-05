using AeLPruebaTecnica.Logic.ObjectOrientation;

namespace AeLPruebaTecnica.Logic.Linq;

internal class Linq
{
    List<int> numbersFilter = new List<int> { 1, 59 };
    List<Cotizante> cotizantes = new List<Cotizante>
        {
            new Cotizante { _Nombre = "Juan", _Apellido = "Perez", _TipoCotizante = 1 },
            new Cotizante { _Nombre = "Maria", _Apellido = "Gomez", _TipoCotizante = 20 },
            new Cotizante { _Nombre = "Pedro", _Apellido = "Garcia", _TipoCotizante = 30 },
            new Cotizante { _Nombre = "Luis", _Apellido = "Lopez", _TipoCotizante = 40 },
            new Cotizante { _Nombre = "Ana", _Apellido = "Diaz", _TipoCotizante = 59 }
        };
    public List<Cotizante> FilterCotizante()
    {
        Console.WriteLine("Ejecutando ejercicio de cotizante Linq");
        List<Cotizante> contizantesFiltrados = cotizantes
            .Where(x => numbersFilter.Contains(x._TipoCotizante))
            .OrderBy(x => x._Apellido)
            .ToList();
        return contizantesFiltrados;
    }   
}

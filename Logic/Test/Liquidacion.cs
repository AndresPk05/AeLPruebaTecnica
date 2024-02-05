namespace AeLPruebaTecnica.Logic.Test;

public class Liquidacion
{
    public int CalcularLiquidacion(int number1, int number2, int number3)
    {
        if(number1 < 0 || number2 < 0 || number3 < 0) throw new Exception("Los números no pueden ser negativos");
        int resultSum = number1 + number2 + number3;
        return resultSum;
    }
}

public class Temperatura
{
    public double Valor { get; set; }


    public double ConverterParaFahrenheit()
    {
        return (Valor * 9 / 5) + 32;
    }

    public double ConverterParaKelvin()
    {
        return Valor + 273.15;
    }
}

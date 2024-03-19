namespace ConversorMoedaQA
{
    public class TemperaturaBLL
    {
        public static void ValidarDados(Temperatura temperatura)
        {
            Erro.TemErro = false;

            if (temperatura.Valor <= -273.15)
            {
                Erro.Mensagem = "Temperatura abaixo do zero absoluto não é válida!";
                Erro.TemErro = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedaQA
{
    class TemperaturaBLL
    {
        public static void ValidarDados(Temperatura novaTemperatura)
        {
            Erro.TemErro = false;

            //faz a validação da Base
            if (novaTemperatura.Valor.Length == 0)
            {
                Erro.Mensagem = "O campo Valor é obrigatório!";
                return;
            }
            else
            {
                try
                {
                    float.Parse(novaTemperatura.Valor);
                }
                catch
                {
                    Erro.Mensagem = "O campo Valor deve ser Númerico!";
                    return;
                }
                if (float.Parse(novaTemperatura.Valor) <= 0)
                {
                    Erro.Mensagem = "O campo valor ser maior ou igual que 0 !";
                    return;
                }
            }
        }
    }
}


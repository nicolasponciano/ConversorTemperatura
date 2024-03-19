using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedaQA
{
    class Erro
    {
        public static bool TemErro { get; set; }


        private static string mensagem; //atributo: é uma variável da classe

        public static string Mensagem //Classe
        {
            get { return mensagem; }
            set { mensagem = value; TemErro = true; }
        }
    }
}

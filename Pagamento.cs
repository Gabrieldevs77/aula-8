using System;

namespace aula_8
{
    public class Pagamento
    {
            public class pagamento
    {
        // get = permissão de leitura da variavel
        // set = permissão de escrita da variavel
        public DateTime data {get; set; }

        public float valor { get; set; }

        public string pagar(){
            return "pagamento efetuado";
        }
        public string cancelar(){
            return "pagamento cancelado";
        }
    }
    }
}
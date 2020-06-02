namespace aula_8
{
     public class Cartao : Pagamento
    {
        public int numero{get;set;}

        public string  titular {get;set;}

        public string bandeira{get;set;}

        public string cvv{get;set;}

        public string token ="fkakfakfskfakfkf993";

        public bool ValidarCartao(){
            if(token != null){
                return true;
            }
            return false;
        }
    }
}
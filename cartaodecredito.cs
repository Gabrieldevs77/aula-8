namespace aula_8
{
     public class cartaodecredito : Cartao
    {
        public float limite { get; set; }

        public float AumentarLimite(float limiteatual,float acrescimo){
            return limiteatual + acrescimo;
        }

        public string BloquearCartaodeCredito(){
            return "Cartao de credito bloqueado";
        }
        
    }
}
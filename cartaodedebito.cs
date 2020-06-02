namespace aula_8{
        public class cartaodebito : Cartao
    {
        public float saldo { get; set; }

        public string Transferir(float valor){
            return$"R$ {valor} transferido da sua conta";
        }
        
    }
}
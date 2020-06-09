namespace Aula13Uber
{
    public class Usuario
    {
        public string Nome { get; set; }
        private string login = "dias@gmail.com";    
        private string senha = "a1b2c3d4";
        public string Foto { get; set; }
        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }

        public bool Login(string login, string senha){
            if(this.login == login && this.senha == senha){
                TokenLogin = "opwqkqwosdoqwsodkowoqkdo313e12"
                return true;
            }
            return false;

        }
        public bool Logout(){
            TokenLogin = "";
        }
    }
}
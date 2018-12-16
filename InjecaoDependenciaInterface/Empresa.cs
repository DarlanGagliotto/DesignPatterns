using System;


namespace InjecaoDependenciaInterface 
{
    public class Empresa : IObjetoEnderecoIJ
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }
        private IObjetoEndereco Endereco { get; set; }
        
        public void setEndereco(IObjetoEndereco obj)
        {
            this.Endereco = obj;
        }
    }
}

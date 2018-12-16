using System;


namespace InjecaoDependenciaServiceLocator
{
    public class Empresa
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }
        private IObjetoEndereco Endereco { get; set; }

        public Empresa()
        {
            this.Endereco = Localizador.GetEndereco();
        }
    }
}

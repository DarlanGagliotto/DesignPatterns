using System;
using System.Reflection.Emit;

namespace InjecaoDependencia
{
    public class Empresa
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public IObjetoEndereco Endereco { get; set; }

        public Empresa(IObjetoEndereco objeto)
        {
            this.Endereco = objeto;
        }
    }
}

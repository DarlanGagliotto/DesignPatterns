using System;

namespace InjecaoDependenciaServiceLocator
{
    public class EnderecoB : IObjetoEndereco
    {
        public string UF { get; set; }
        public string Cidade { get; set; }
    }
}

using System;

namespace InjecaoDependenciaInterface 
{
    public class EnderecoB : IObjetoEndereco
    {
        public string UF { get; set; }
        public string Cidade { get; set; }
    }
}

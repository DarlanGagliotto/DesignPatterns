using System;

namespace InjecaoDependencia
{
    public class EnderecoB : IObjetoEndereco
    {
        public string UF { get; set; }
        public string Cidade { get; set; }
    }
}

using System;

namespace InjecaoDependencia
{
    class Program
    {
        static void Main(string[] args)
        {   
            EnderecoA enderecoA = new EnderecoA();
            enderecoA.Rua = "Rua Endereço A";
            enderecoA.Numero = 10;

            EnderecoB enderecoB = new EnderecoB();
            enderecoB.Cidade = "Blumenau";
            enderecoB.UF = "SC";

            Empresa empresa1 = new Empresa(enderecoA);

            Empresa empresa2 = new Empresa(enderecoB);
        }
    }
}

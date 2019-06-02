using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class MilharesExpresao : Expressao
    {
        public override string Cinco()
        {
            return "D";
        }

        public override int Multiplicar()
        {
            return 1000;
        }

        public override string Nove()
        {
            return " ";
        }

        public override string Quatro()
        {
            return " ";
        }

        public override string Um()
        {
            return "M";
        }
    }
}

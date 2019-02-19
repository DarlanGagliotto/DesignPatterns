using System;

namespace TermplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass classAbstract_A = new ConcreteClassA();
            classAbstract_A.TemplateMethod();

            AbstractClass classAbstract_B = new ConcreteClassB();
            classAbstract_B.TemplateMethod();

            Console.ReadKey();
        }
    }
}

using System;

namespace ChainOfResponsability
{
    public class ConcreteHandler3 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if(request >= 20 && request < 30)
                Console.WriteLine("{0} Handled request {1}", this.GetType().Name, request);
            else if (request != null)
                sucessor.HandlerRequest(request);
        }
    }
}

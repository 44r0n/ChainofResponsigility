using System;

namespace ChainofResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handler1, handler2;
            handler1 = new ConcreteHandler1(false);
            handler2 = new ConcreteHandler2(true);
            handler1.SetSuccessor(handler2);
            handler1.HandleRequest("Hello world");
        }
    }
}

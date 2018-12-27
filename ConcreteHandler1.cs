namespace ChainofResponsibilityPattern
{
    public class ConcreteHandler1 : Handler
    {
        public ConcreteHandler1(bool canHandle) : base(canHandle)
        {
        }

        public override void ProcessRequest(string message)
        {
            System.Console.WriteLine("ConcreteHandler1 processes: "+message);
        }
    }
}
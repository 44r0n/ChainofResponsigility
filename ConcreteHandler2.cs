namespace ChainofResponsibilityPattern
{
    public class ConcreteHandler2 : Handler
    {
        public ConcreteHandler2(bool canHandle) : base(canHandle)
        {
        }

        public override void ProcessRequest(string message)
        {
            System.Console.WriteLine("ConcreteHanlder2 processes: "+message);
        }
    }
}
namespace ChainofResponsibilityPattern
{
    public abstract class Handler
    {
        public bool canHandle;
        private Handler successor = null;
        public Handler(bool canHandle) => this.canHandle = canHandle;
        public void SetSuccessor(Handler successor) => this.successor = successor;
        public void HandleRequest(string message)
        {
            if(canHandle)
            {
                ProcessRequest(message);
            }
            if(successor != null)
            {
                successor.HandleRequest(message);
            }
        }

        public abstract void ProcessRequest(string message);
    }
}
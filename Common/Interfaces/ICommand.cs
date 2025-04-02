namespace MashBoxBridge.Common.Interfaces
{
    public interface ICommand
    {
        public void Execute();
    
        public void Undo();
    }
    public abstract class CommandBase : ICommand
    {
        protected string _actionType;
        protected string _parameters;
    
        protected CommandBase(string actionType, string parameters = null)
        {
            _actionType = actionType;
            _parameters = parameters;
        }
    
        public abstract void Execute();
    
        public abstract void Undo();
    }
}
namespace Patterns.State
{
    public interface ISetState
    {
        public void SetCurrentState(IStateBase newState);
    }
}
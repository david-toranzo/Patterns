namespace Patterns.State
{
    public interface IStateMachine
    {
        public void SetCurrentState(IStateBase newState);

        public void RunStayCurrentState();
    }
}
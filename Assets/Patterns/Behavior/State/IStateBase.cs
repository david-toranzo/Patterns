namespace Patterns.State
{
    public interface IStateBase
    {
        public void Enter();

        public void Exit();

        public void Stay();
    }
}
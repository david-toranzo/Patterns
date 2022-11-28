namespace Patterns.State
{
    public abstract class TransitionVerificationEnterExit : TransitionVerification
    {
        public abstract void Enter();

        public abstract void Exit();
    }
}

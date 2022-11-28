namespace Patterns.State
{
    public abstract class TransitionVerification : Transition
    {
        protected bool _transitionVerificationValue = false;

        public void SetTransitionVerificationToTrue()
        {
            _transitionVerificationValue = true;
        }

        public override bool GetProcessTransitionVerification()
        {
            bool newCondition = _transitionVerificationValue;

            if (_transitionVerificationValue)
                _transitionVerificationValue = false;

            return newCondition;
        }

    }
}

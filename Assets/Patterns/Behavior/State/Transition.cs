using UnityEngine;

namespace Patterns.State
{
    public abstract class Transition : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] protected StateBase _nextStateMove;

        public virtual StateBase GetNextStateMove() => _nextStateMove;

        public abstract bool GetProcessTransitionVerification();
    }

}
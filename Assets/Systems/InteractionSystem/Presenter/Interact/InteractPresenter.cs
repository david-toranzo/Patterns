using System;

namespace Interaction
{
    public class InteractPresenter : IInteractPresenter
    {
        public Action OnInteract { get; set; }

        private IInteract _interactSubscribe;

        public InteractPresenter(IInteract interactSubscribe)
        {
            _interactSubscribe = interactSubscribe;

            _interactSubscribe.OnInteract += ReceiveEventInteract;
        }

        private void ReceiveEventInteract()
        {
            OnInteract.Invoke();
        }
    }
}
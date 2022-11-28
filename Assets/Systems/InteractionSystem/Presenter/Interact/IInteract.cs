using System;

namespace Interaction
{
    public interface IInteract
    {
        Action OnInteract { get; set; }
    }
}
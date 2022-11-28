using Toranzo.Installer;
using UnityEngine;

namespace Patterns.ChainOfResponsability.GetMessage
{
    public class ChainSameUserVerificatorInstaller : MonoInstaller<IChain>
    {
        [SerializeField] private MonoInstaller<IGetCurrentUser> _getIsTheSameUser;

        protected override IChain GetDataType()
        {
            return new ChainSameUserVerificator(_getIsTheSameUser.Data);
        }
    }
}
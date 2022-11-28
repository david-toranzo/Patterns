using Toranzo.Installer;

namespace Patterns.ChainOfResponsability.GetMessage
{
    public class ChainDefaultInstaller : MonoInstaller<IChain>
    {
        protected override IChain GetDataType()
        {
            return new ChainDefault();
        }
    }
}
using static UnityEngine.UI.Button;

namespace Toranzo.List.View
{
    public class ActionListButtonGetterInstaller : ActionListItemGetterInstaller<ButtonClickedEvent>
    {
        protected override IActionListItemGetter<ButtonClickedEvent> GetDataType()
        {
            return new ActionListButtonGetter();
        }
    }
}
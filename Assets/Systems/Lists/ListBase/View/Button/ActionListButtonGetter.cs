using Toranzo.Installer;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Button;

namespace Toranzo.List.View
{
    public class ActionListButtonGetter : IActionListItemGetter<ButtonClickedEvent>
    {
        public ButtonClickedEvent GetDataActionFromObject(GameObject goAction)
        {
            return goAction.GetComponent<Button>().onClick;
        }
    }
}
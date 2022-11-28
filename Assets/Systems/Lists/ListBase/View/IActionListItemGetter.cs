using UnityEngine;

namespace Toranzo.List.View
{
    public interface IActionListItemGetter<DataActionType>
    {
        DataActionType GetDataActionFromObject(GameObject goAction);
    }
}
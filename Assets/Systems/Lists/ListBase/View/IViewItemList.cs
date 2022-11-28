using System;

namespace Toranzo.List.View
{
    public interface IViewItemList
    {
        Action OnClickList { get; set; }
    }
}
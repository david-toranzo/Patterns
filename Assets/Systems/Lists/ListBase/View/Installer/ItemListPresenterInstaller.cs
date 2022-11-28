using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.List.View
{
    public abstract class ItemListPresenterInstaller<DataType> : MonoInstaller<IItemListPresenter<DataType>>
    {
        [SerializeField] protected MonoInstaller<IObjectShowInformationList<DataType>> _objectShowInformation;
    }
}
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Toranzo.List.View
{
    public abstract class ViewItemList : MonoBehaviour, IViewItemList
    {
        public Action OnClickList { get; set; }

        [SerializeField] private Button _buttonClick;

        private void Awake()
        {
            _buttonClick.onClick.AddListener(() => OnClickList?.Invoke());
        }
    }
}
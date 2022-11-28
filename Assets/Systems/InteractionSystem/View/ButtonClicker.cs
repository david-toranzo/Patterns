using System;
using UnityEngine;
using UnityEngine.UI;

namespace Interaction
{
    public class ButtonClicker : MonoBehaviour, IInteract
    {
        public Action OnInteract { get; set; }

        [SerializeField] private Button _buttonClick;

        private void Awake()
        {
            _buttonClick.onClick.AddListener(() => OnInteract.Invoke());
        }
    }
}
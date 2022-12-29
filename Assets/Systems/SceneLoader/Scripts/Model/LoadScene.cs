using System;
using Patterns.ServiceLocator;
using UnityEngine;

namespace Toranzo.SceneSystem
{
    public class LoadScene : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private SceneDataSO _sceneDataSO;

        public void Load()
        {
            ServiceLocator.Instance.GetService<ISceneLoader>().LoadScene(_sceneDataSO.SceneData);
        }
    }
}
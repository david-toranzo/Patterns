using UnityEngine;

namespace Toranzo.SceneSystem
{
    [CreateAssetMenu(fileName = "SceneData", menuName = "ScriptableObjects/SceneData")]
    public class SceneDataSO : ScriptableObject
    {
        [SerializeField] private SceneData sceneData;

        public SceneData SceneData { get => sceneData; }
    }
}
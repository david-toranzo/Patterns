using UnityEngine;

namespace Toranzo.ObjectPool
{
    public class GameObjectPoolInstance : ObjectPoolInstance<GameObject>
    {
        protected override void BeforeReturnThisInstanceToPool()
        {
            gameObject.SetActive(false);
        }

        protected override GameObject GetTypeDiscardObject()
        {
            return this.gameObject;
        }
    }
}
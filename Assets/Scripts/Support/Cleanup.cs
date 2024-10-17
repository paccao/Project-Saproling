using UnityEngine;

namespace Assets.Scripts.PlayerScripts.Support
{
    public class Cleanup : MonoBehaviour
    {
        public float Delay = 0.1f;

        void Update()
        {
            Destroy(gameObject, Delay);
        }
    }
}
